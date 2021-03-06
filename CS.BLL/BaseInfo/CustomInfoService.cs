﻿using CS.DAL;
using KNDBsys.Model.BaseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.BLL.BaseInfo
{
    public class CustomInfoService : PostService<CustomInfo,CustomInfo>
    {
        public List<CustomInfo> GetAllCustomInfos(int userid)
        {
            string url = KNDBsysUrl.BaseInfoUrl.CustomInfoUrl.GetAllCustomInfo;
            HttpTools tools = new HttpTools();
            tools.AddParam("userid", userid).Build(); ;
            return GetList(url, tools);
        }

        public int AddCustomInfo(CustomInfo customInfo)
        {
            string url = KNDBsysUrl.BaseInfoUrl.CustomInfoUrl.AddCustomInfo;
            HttpTools tools = new HttpTools();
            tools.AddParam("customInfo", DataSwitch.DataToJson(customInfo)).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt();
        }

        public bool UpdateCustomInfo(CustomInfo customInfo)
        {
            string url = KNDBsysUrl.BaseInfoUrl.CustomInfoUrl.UpdatCustomInfo;
            HttpTools tools = new HttpTools();
            tools.AddParam("customInfo", DataSwitch.DataToJson(customInfo)).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt() > 0;
        }

        public bool DeleteCustomInfo(CustomInfo customInfo)
        {
            string url = KNDBsysUrl.BaseInfoUrl.CustomInfoUrl.DeleteCustomInfo;
            HttpTools tools = new HttpTools();
            tools.AddParam("customInfo", DataSwitch.DataToJson(customInfo)).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt() > 0;
        }

        public int CountcustomTel(string tel)
        {
            string url = KNDBsysUrl.BaseInfoUrl.CustomInfoUrl.CountCustomTel;
            HttpTools tools = new HttpTools();
            tools.AddParam("tel", tel).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt() ;
        }

        public CustomInfo FindCustomByTel(string tel)
        {
            string url = KNDBsysUrl.BaseInfoUrl.CustomInfoUrl.FindCustomByTel;
            HttpTools tools = new HttpTools();
            tools.AddParam("tel", tel).Build();
            CustomInfo custom = GetEntity(url, tools);
            return custom;
        }

        public CustomInfo FindCustomByid(int customid)
        {
            string url = KNDBsysUrl.BaseInfoUrl.CustomInfoUrl.FindCustomByid;
            HttpTools tools = new HttpTools();
            tools.AddParam("customid", customid).Build();
            CustomInfo custom = GetEntity(url, tools);
            return custom;
        }

    }
}
