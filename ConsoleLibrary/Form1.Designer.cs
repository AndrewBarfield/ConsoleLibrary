namespace ConsoleTestBed
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.richConsoleBox1 = new ConsoleLibrary.RichConsoleBox();
			this.SuspendLayout();
			// 
			// richConsoleBox1
			// 
			this.richConsoleBox1.AcceptsTab = true;
			this.richConsoleBox1.BackColor = System.Drawing.Color.Black;
			this.richConsoleBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richConsoleBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richConsoleBox1.Font = new System.Drawing.Font( "Lucida Console", 8F );
			this.richConsoleBox1.ForeColor = System.Drawing.Color.Lime;
			this.richConsoleBox1.Location = new System.Drawing.Point( 0, 0 );
			this.richConsoleBox1.Name = "richConsoleBox1";
			this.richConsoleBox1.RightMargin = 640;
			this.richConsoleBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.richConsoleBox1.Size = new System.Drawing.Size( 658, 538 );
			this.richConsoleBox1.TabIndex = 0;
			this.richConsoleBox1.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size( 658, 538 );
			this.Controls.Add( this.richConsoleBox1 );
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout( false );

		}

		#endregion

		private ConsoleLibrary.RichConsoleBox richConsoleBox1;














	}
}

