using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace SMS
{
    public partial class SplashSceen : Form
    {
        public SplashSceen()
        {
            InitializeComponent();
        }
        public int timeLeft { get; set; }
        private void splsTimer_Tick(object sender, EventArgs e)
        {
            //if (timeLeft > 0)
            //{
            //    timeLeft = timeLeft - 1;

            //}
            //else
            //{
            //    splsTimer.Stop();
            //    new Login().Show();
            //    this.Hide();
            //}
        }
        //String spath = Application.StartupPath + "\\FN.txt";
        private void SplashSceen_Load(object sender, EventArgs e)
        {

        //    System.IO.StreamWriter myStreamWriter = null;

        //Process[] p=    System.Diagnostics.Process.GetProcessesByName("chrome");

        //    if (p.Length > 0)
        //    {



        //        if (!(File.Exists(spath)) == true)
        //        {
        //            myStreamWriter = File.CreateText(spath);
        //            myStreamWriter.Write("");

        //            myStreamWriter.Flush();
        //            myStreamWriter.Close();

        //            Application.Exit();




        //        }


        //        else
        //        {
        //            String STR = File.ReadAllText(spath);



        //            if (STR.Length > 0)
        //            {
        //                if (STR == "1")
        //                {

        //                    new AdminPanel().Show();
        //                    this.Hide();


        //                }
        //                else
        //                {
        //                    Application.Exit();
        //                }


        //            }
        //        }


        //    }
        //    else
        //    {
        //        Application.Exit();
        //    }



            //timeLeft = 10;
            //splsTimer.Start();
        }

       

        }
    }
