﻿using MetroFramework.Forms;
using SynDSStudent.Method;
using SynDSStudent.Present;
using SynDSStudent.ReadCard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SynDSStudent
{
    public partial class CheckStudent : MetroForm
    {

        private UpdataTask uT;
        private ReadIDCardClass rcc;

        public CheckStudent()
        {
            InitializeComponent();
        }

        private void CheckStudent_Load(object sender, EventArgs e)
        {
            uT = new UpdataTask();
            rcc = new ReadIDCardClass();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            uT.UpdataHisData();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            uT.UploadAllStu(Uploadstauts);
        }

        private void btn_rc_Click(object sender, EventArgs e)
        {
            ReadIDInfo rii = new ReadIDInfo();
            rcc.Readcardinfo(out rii);
           
        }

        private void Uploadstauts(int value)
        {
            mps.Value = value;
        }

    }
}
