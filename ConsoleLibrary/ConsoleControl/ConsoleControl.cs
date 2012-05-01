
using System;
using System.Collections.Specialized;	// StringCollection
using System.Drawing;			// Color
using System.Text;			// StringBuilder
using System.Windows.Forms;		// DUH!
using System.Diagnostics;		// Process
using System.IO;			// StreamWriter, StreamReader
using System.Threading;			// Thread


namespace ConsoleLibrary
{

	/// <summary>
	/// Windows Forms Console Control
	/// </summary>
	public partial class ConsoleControl : UserControl
	{


		/*
		
		#region Delegates
			/// <summary>
			/// Executed on the thread that owns the RichTextBox, when the cmd.exe process exits
			/// </summary>
			private delegate void delegate_RTB_Exited();
			private delegate_RTB_Exited handler_RTB_Exited;


			public delegate void ExitEventHandler( object sender, EventArgs e );
			public delegate void OutputDataAvailableCallback( string text, bool IsStandardError );

		#endregion



		#region Events

			/// <summary>
			/// Occurs when the Console exits
			/// </summary>
			public event ExitEventHandler Exit;


			/// <summary>
			/// Occurs when StandardOutput or StandardError data is available
			/// </summary>
			public OutputDataAvailableCallback OutputDataAvailable;

		#endregion



		#region Fields

			/// <summary>
			/// Provides access the cmd.exe process
			/// </summary>
			public Process processCMD = null;


			/// <summary>
			/// 
			/// </summary>
			private StreamWriter StandardInputWriter = null;


			/// <summary>
			/// Collection of previously executed command lines
			/// </summary>
			//private StringCollection scCommandLineHistory = null;

			private Thread threadStandardOutput = null;
			private Thread threadStandardError = null;

		#endregion



		#region UserControl

			/// <summary>
			/// Creates and instance of the Console Control
			/// </summary>
			public ConsoleControl()
			{

				InitializeComponent();


				// Delegates for invoked methods
				handler_RTB_Exited = new delegate_RTB_Exited( ExitedMethod );


				// scCommandLineHistory holds old command lines for quick reuse
				//scCommandLineHistory = new StringCollection();

			}


			/// <summary>
			/// 
			/// </summary>
			/// <param name="sender"></param>
			/// <param name="e"></param>
			private void ConsoleControl_Load( object sender, EventArgs e )
			{

				if ( !this.DesignMode )
					StartConsoleSession();

			}

		#endregion


		private void StartConsoleSession()
		{

			// 
				if ( processCMD != null )
					return;


			// Create the cmd.exe background process
				processCMD = new Process();


			// ProcessStartInfo is used together with the Process component.
				processCMD.StartInfo.Arguments = "/Q";
				processCMD.StartInfo.CreateNoWindow = true;
				processCMD.StartInfo.FileName = "cmd.exe";
				processCMD.StartInfo.RedirectStandardError = true;
				processCMD.StartInfo.RedirectStandardOutput = true;
				processCMD.StartInfo.RedirectStandardInput = true;
				processCMD.StartInfo.UseShellExecute = false;
				processCMD.StartInfo.WorkingDirectory = Environment.GetFolderPath( Environment.SpecialFolder.MyDocuments );
				processCMD.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;


			// Process
				OutputDataAvailable = new OutputDataAvailableCallback( OutputCallback );
				processCMD.Exited += new EventHandler( processCMD_Exited );
				processCMD.EnableRaisingEvents = true;


			// Start
				if ( processCMD.Start() )
				{

					// Standard Streams
					StandardInputWriter = processCMD.StandardInput;
					threadStandardOutput = BeginBackgroundReader( "threadStandardOutput", processCMD.StandardOutput );
					threadStandardError = BeginBackgroundReader( "threadStandardError", processCMD.StandardError );

				}
		}




                        #region Background Thread


			/// <summary>
			/// Creates a background thread that reads from cmd.exe StandardOutput
			/// </summary>
			private Thread BeginBackgroundReader( string threadName, StreamReader reader )
			{

				Thread threadReader = new Thread( new ParameterizedThreadStart( threadBackgroundReaderMethod ) );
				threadReader.Name = threadName;
				threadReader.IsBackground = true;
				threadReader.Start( reader );

				return threadReader;
			}


			/// <summary>
			/// Thread method used to read and display StandardOutput
			/// </summary>
			/// <param name="data"></param>
                                    private void threadBackgroundReaderMethod( object data )
                                    {

				StreamReader reader = data as StreamReader;
				bool isStandardError = reader.Equals( processCMD.StandardError );

                                                try
                                                {

					while ( !reader.EndOfStream )
					{



						char[] buffer = new char[4096];
						

						if ( reader.Read( buffer, 0, 4096 ) > 0 )
							this.BeginInvoke( OutputDataAvailable, new object[] { new string( buffer, 0, buffer.Length ), isStandardError } );


						buffer = null;
						
					}

                                                }
                                                catch ( Exception )
                                                {
                                                }
				finally
				{
				}

			

			}

		
                        #endregion



		#region OutputCallback


			private void OutputCallback( string text, bool IsStandardError )
			{


				try
				{


					if ( IsStandardError )
					{
						rtbConsole.AppendFormattedText( text, Color.Salmon );
					}
					else
					{
						rtbConsole.AppendText( text );
					}

				}
				catch ( Exception )
				{
				}

			}

		#endregion



		#region Process Exited / Disposed

			/// <summary>
			/// The Exited event indicates that the associated process exited.
			/// ms-help://MS.LHSMSSDK.1033/MS.LHSNETFX30SDK.1033/fxref_system/html/ebbb0d6a-b7dd-743d-b7a5-cdff7626d7f6.htm
			/// </summary>
			/// <param name="sender"></param>
			/// <param name="e"></param>
			private void processCMD_Exited( object sender, EventArgs e )
			{

				rtbConsole.Invoke( handler_RTB_Exited );

			}


			/// <summary>
			/// Invoked on the UserControl Thread to cleanup after the CMD.EXE process has exited,
			/// ms-help://MS.LHSMSSDK.1033/MS.LHSNETFX30SDK.1033/fxref_system/html/ebbb0d6a-b7dd-743d-b7a5-cdff7626d7f6.htm
			/// </summary>
			private void ExitedMethod()
			{

				// RichTextBox
					rtbConsole.ForeColor = Color.Gray;
					rtbConsole.ReadOnly = true;


				// StandardInputWriter
					if ( StandardInputWriter != null )
						StandardInputWriter.Close();


				// Tell anyone listening that CMD.EXE has exited
					if ( Exit != null )
						Exit( this, new EventArgs() );
				
			}

		#endregion

		/*




	}
}
