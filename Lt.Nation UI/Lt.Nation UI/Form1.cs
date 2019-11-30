using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinitySeal;
using Newtonsoft;
using TrinityGUI;
using System.Threading;
namespace Lt.Nation_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
            SealCheck.HashChecks();

            if (SealCheck.isValidDLL)
            {
                //new Form2() can be changed to the form that you want to show after login
                //SealColours.Red can be changed to any colour that you like
                //The form will automatically carry out all tasks such as grabbing variables and showing then next form is login is successful, or if freemode is enabled
                TrinitySeal.Seal.InitializeForm("88zG4ZGbXcu8BzOgUYjFJG3kwWY7ACZx41PNForo8f1Z7", "1.0", "", this, new Form2(), SealColours.Orange);
            }
            
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
