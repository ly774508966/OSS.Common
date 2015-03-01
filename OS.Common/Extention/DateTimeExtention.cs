﻿using System;

namespace OS.Common.Extention
{
    public static class DateTimeExtention
    {
        /// <summary>
        /// 获取距离1970-01-01 的秒数（格林威治时间）
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static long GetSecondsUTC(this DateTime time)
        {
            return (long)(time.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds;
        }


    }
}
