﻿using DsParkOffLine.ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DsParkOffLine
{
    public class TaskPresident
    {
        private DataCenter dc;

        public TaskPresident() 
        {
            dc = new DataCenter();
        }

        public void LoadStudentData()
        {
            DataTable dt = dc.GetAllStudents();
            if (dt.Rows.Count == 0) return;
            dc.DelDBStudent();
            dc.InsDBstudent(dt);
            DataTable hdt = dc.GetHistory();
            dc.InsDBHistory(hdt);
        }

        public DSstu GetStuInSqlite(string str)
        {
            return dc.GetDSstubyNO(str);
        }

        public List<DsHistory> GetDSHisInSqllite(string stuid)
        {
            return dc.GetDShislist(stuid);
        }

        public bool CheckConnect()
        {
            return SerSQLhelper.TestConnect();
        }

    }
}
