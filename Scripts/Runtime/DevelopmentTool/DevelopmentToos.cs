using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GGG.Tool
{
    public class DevelopmentToos
    {

        /// <summary>
        /// 日志工具类
        /// </summary>
        /// <param name="message"></param>
        public static void WTF(object message)
        {
            Debug.LogFormat($"日志内容:<color=#ff0000> --->   {message}   <--- </color>");
        }
    }
}
