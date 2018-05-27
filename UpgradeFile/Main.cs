﻿using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UpgradeFile
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private FileLoadPresent fileLoadPresent = new FileLoadPresent();

        private void Main_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_upgrade_Click(object sender, EventArgs e)
        {

            PostData<SysVer, SysVer> post = fileLoadPresent.GetNewVersion();
            if (post == null || post.MCount == 0)
            {
                MetroMessageBox.Show(this, "获取版本失败，请重新获取。");
                return;
            }

            string amb = Application.StartupPath + "\\ServerRecord.exe";
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(amb);
            string verstring = fvi.FileVersion;
            if (verstring == post.Entity.sysver)
            {
                MetroMessageBox.Show(this, "该版本为最新版本，无需升级！");
                return;
            }
            string str = Application.StartupPath + "/";

            fileLoadPresent.DownLoadFile("", str + post.Entity.filelist, probar);
            //fileLoadPresent.DownLoadFile("1.0.0.0/NPOI.dll", @"C:\DataBase\download\NPOI.dll", probar);
        }
    }
}
