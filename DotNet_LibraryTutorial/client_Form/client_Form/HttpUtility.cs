﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client_Form
{
    public class HttpUtility
    {
        public static string ProxyString = string.Empty;
        /// <summary>
        /// Get Request
        /// </summary>
        /// <param name="URI"></param>
        /// <returns></returns>
        public static string HttpGet(string URI)
        {
            System.Net.WebRequest req = System.Net.WebRequest.Create(URI);
            //req.Proxy = new System.Net.WebProxy(ProxyString, true); //true means no proxy
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            return sr.ReadToEnd().Trim();
            
        }

        /// <summary>
        /// Post Request
        /// </summary>
        /// <param name="URI"></param>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        //public static string HttpPost(string URI, string Parameters)
        //{
        //    System.Net.WebRequest req = System.Net.WebRequest.Create(URI);
        //    //req.Proxy = new System.Net.WebProxy(ProxyString, true);
        //    //Add these, as we're doing a POST
        //    req.ContentType = "application/x-www-form-urlencoded";
        //    req.Method = "POST";
        //    //We need to count how many bytes we're sending. Post'ed Faked Forms should be name=value&
        //    byte[] bytes = System.Text.Encoding.ASCII.GetBytes(Parameters);
        //    req.ContentLength = bytes.Length;
        //    System.IO.Stream os = req.GetRequestStream();
        //    os.Write(bytes, 0, bytes.Length); //Push it out there
        //    os.Close();
        //    System.Net.WebResponse resp = req.GetResponse();
        //    if (resp == null) return null;
        //    System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
        //    return sr.ReadToEnd().Trim();
        //}
    }
}
