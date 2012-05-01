using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ConsoleLibrary;

namespace ConsoleTestBed
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			richConsoleBox1.Exit += new RichConsoleBox.ExitEventHandler( richConsoleBox1_Exit );
		}




		void richConsoleBox1_Exit( object sender, EventArgs e )
		{
			this.Close();
		}
	}
}
