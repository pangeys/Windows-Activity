using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Windows_Activity
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
    	bool loggedIn = false;

    	while (!loggedIn)
    	{
        	if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
        	{
            	MessageBox.Show("Please enter both username and password.");
            	return;
        	}

        		if (txtUser.Text == "Pangeys" && txtPass.Text == "airon")
        		{
            		Form1 f2 = new Form1();
            		f2.Show();
            		this.Hide();
            		loggedIn = true;
        		}
        		else
        		{
            		MessageBox.Show("Invalid username or password. Please try again.");
            		txtPass.Text = "";
            		txtPass.Focus();
        		}
    		}
		}

	}
}
