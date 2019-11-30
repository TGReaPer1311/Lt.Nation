using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FastColoredTextBoxNS;
using TrinityGUI;
using TrinitySeal;
using Newtonsoft;


namespace Lt.Nation_UI
{

    public partial class Form2 : Form
    {
        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LaunchExploit();

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendLuaCScript(string script);

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendLimitedLuaScript(string script);

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendCommand(string script);
        public Form2()
        {

            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
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
        private void Form2_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Form2_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button5.Visible = false;
            fastColoredTextBox1.Text = ("Lua Script");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            button2.Visible = false;
            fastColoredTextBox1.Text = ("Lua C Script");
        }
    }
}

