using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FastColoredTextBoxNS;


namespace Lt.Nation_UI
{

    public partial class Form1 : Form
    {
        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LaunchExploit();

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendLuaCScript(string script);

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendLimitedLuaScript(string script);

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendCommand(string script);
        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LaunchExploit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SendLimitedLuaScript(fastColoredTextBox1.Text);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SendLuaCScript(fastColoredTextBox1.Text);
        }


    }
}

