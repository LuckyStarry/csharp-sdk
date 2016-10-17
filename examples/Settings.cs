﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QiniuDemo
{
    public class Settings
    {
        //see ak sk from https://portal.qiniu.com/user/key
        public static string AccessKey;
        public static string SecretKey;
        private static bool loaded = false;

        public static void load()
        {
            if (!loaded)
            {
                AccessKey = "<Your Access Key>";
                SecretKey = "<Your Secret Key>";

                loaded = true;
            }
        }

        /// <summary>
        /// 仅在测试时使用，文本文件(cFile)中逐行存放：AK,SK
        /// </summary>
        /// <param name="cFile"></param>
        public static void LoadFromFile(string cFile="F:\\test.cfg")
        {
            if (!loaded)
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(cFile))
                {
                    AccessKey = sr.ReadLine();
                    SecretKey = sr.ReadLine();
                    sr.Close();
                }

                loaded = true;
            }
        }
    }
}
