namespace ConsoleLibrary
{
	partial class ConsoleControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.rtbConsole = new RichConsoleBox();
			this.contextMenuStripConsole = new System.Windows.Forms.ContextMenuStrip( this.components );
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStripConsole.SuspendLayout();
			this.SuspendLayout();
			// 
			// rtbConsole
			// 
			this.rtbConsole.BackColor = System.Drawing.Color.Black;
			this.rtbConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbConsole.ContextMenuStrip = this.contextMenuStripConsole;
			this.rtbConsole.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbConsole.Font = new System.Drawing.Font( "Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
			this.rtbConsole.ForeColor = System.Drawing.Color.Lime;
			this.rtbConsole.HideSelection = false;
			this.rtbConsole.Location = new System.Drawing.Point( 0, 0 );
			this.rtbConsole.Name = "rtbConsole";
			this.rtbConsole.Size = new System.Drawing.Size( 436, 353 );
			this.rtbConsole.TabIndex = 0;
			this.rtbConsole.Text = "";
			// 
			// contextMenuStripConsole
			// 
			this.contextMenuStripConsole.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem} );
			this.contextMenuStripConsole.Name = "contextMenuStripConsole";
			this.contextMenuStripConsole.Size = new System.Drawing.Size( 103, 70 );
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.Size = new System.Drawing.Size( 102, 22 );
			this.cutToolStripMenuItem.Text = "Cut";
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size( 102, 22 );
			this.copyToolStripMenuItem.Text = "Copy";
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size( 102, 22 );
			this.pasteToolStripMenuItem.Text = "Paste";
			// 
			// ConsoleControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.Controls.Add( this.rtbConsole );
			this.Name = "ConsoleControl";
			this.Size = new System.Drawing.Size( 436, 353 );
			this.Load += new System.EventHandler( this.ConsoleControl_Load );
			this.contextMenuStripConsole.ResumeLayout( false );
			this.ResumeLayout( false );

		}

		#endregion

                        private RichConsoleBox rtbConsole;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripConsole;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;

            }
}
