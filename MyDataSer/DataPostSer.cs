﻿using MetroFramework.Forms;
using MyDataSer.Method;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MyDataSer
{
    public partial class DataPostSer : MetroForm
    {
        public DataPostSer()
        {
            InitializeComponent();
        }

        private GetStudentData gsd;

        private void DataPostSer_Load(object sender, EventArgs e)
        {
            gsd = new GetStudentData();
        }

        private void mbtn_start_Click(object sender, EventArgs e)
        {
            //mps.EnsureVisible = true;
            //mps.Value = 80;
            //PostTimer.Start();
            //mbtn_start.Enabled = false;




        }

        private void mbtn_minsmall_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DataPostSer_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)//最小化　　　　　 
            {
                this.ShowInTaskbar = false;
            }
            else
            {
                this.ShowInTaskbar = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void PostTimer_Tick(object sender, EventArgs e)
        {
            GetStudentData gsd = new GetStudentData();
            gsd.PostData();
        }

        private void mbtn_upload_Click(object sender, EventArgs e)
        {

        }
    }
}
