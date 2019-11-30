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
namespace Lt.Nation_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            SealCheck.HashChecks();
            this.InitializeComponent();
            Seal.Secret = "88zG4ZGbXcu8BzOgUYjFJG3kwWY7ACZx41PNForo8f1Z7";
            Seal.Initialize("1.0");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnShowRegister_Click(object sender, EventArgs e)
        {
            this.btnRegister.Visible = true;
            this.btnShowRegister.Visible = false;
            this.txtBxEmail.Visible = true;
            this.txtBxToken.Visible = true;
            this.BtnLogin.Visible = false;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {

            SealCheck.HashChecks(); // Check integrity of auth files

            if (SealCheck.isValidDLL)
            {
                // The register arguments goes in the order: username, password, email, token
                bool response = TrinitySeal.Seal.Register(txtBxToken.Text, txtBxEmail.Text, txtBxPassword.Text, txtBxUsername.Text);
                if (response)
                {
                    this.btnRegister.Visible = false;
                    this.btnShowRegister.Visible = true;
                    this.txtBxEmail.Visible = false;
                    this.txtBxToken.Visible = false;
                    this.BtnLogin.Visible = true;
                }
                else
                {
                    MessageBox.Show("Register Unsucessful");
                }
            }

        }

        private void Btnshowlog_Click(object sender, EventArgs e)
        {
            this.btnRegister.Visible = false;
            this.BtnLogin.Visible = true;
            this.txtBxEmail.Visible = false;
            this.txtBxToken.Visible = false;
            this.btnShowRegister.Visible = true;
            this.btnshowlog.Visible = true;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
           if (Seal.Login(this.txtBxUsername.Text, this.txtBxPassword.Text, true))
                {
                   new Form2().Show();
                    base.Hide();
                }


        }
    }
    }

