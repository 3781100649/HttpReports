﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HttpReports.Test
{
    [TestClass]
    public class CodeTest
    {

        [TestMethod]
        public void Test1()
        {
            string rule = "/httpreports%";

            var result = rule.Where(x => x == '%').ToList();

            Assert.IsTrue(result.Count() > 0);
        }


        [TestMethod]
        public void Test2()
        {
            string url = "http://dx.dabansuan.com.cn/click.htm?zid=3228&od=0";
            int str = url.IndexOf("od");
            url = url.Insert(str, "_au");
        } 

        public delegate string GetResultDelegate();   

        public HttpConfig GetConfig(Action<HttpConfig> action)
        {
            HttpConfig con = new HttpConfig();

            action(con);

            return con; 

        } 
    } 
  

    public class HttpConfig
    {
        public string Name { get; set; } 
    }

}
