﻿using DevComponents.DotNetBar;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CS.Models.BaseInfo;
using System.Windows.Forms;

namespace CS.UI
{
    public partial class BaseTabFrom : Office2007Form
    {
        public BaseTabFrom()
        {
            InitializeComponent();
            //LoadUserAuth();
        }

        public void LoadUserAuth()
        {
            int formtag =(int) this.Tag;
            foreach (var au in SYSUser.OperAuth)
            {
                if (au.ParentID == formtag)
                {
                    Control[] cons = Controls.Find(au.Path, false);
                    if (cons.Count() > 0)
                    {
                        cons[0].Enabled = false;
                    }
                }
            }
        }

        public void ShowTipsMessageBox(string msg )
        {
            MetroMessageBox.Show(this, msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult ShowWarningMessageBox(string msg)
        {
            return MetroMessageBox.Show(this, msg, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public void ShowErrorMessageBox(string msg)
        {
            MetroMessageBox.Show(this, msg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult ShowQuestionMessageBox(string msg)
        {
            return MetroMessageBox.Show(this, msg, "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

    }
}
