﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartAnalytics.Services.Models
{
    public class VisitorNewOldByDayPageItem
    {
        /// <summary>
        /// 是否新访客true新访客,false老访客
        /// </summary>
        public bool IsNewVisitor { get; set; }

        /// <summary>
        /// 浏览次数
        /// </summary>
        public int PageView { get; set; }

        /// <summary>
        /// 独立访客UV
        /// </summary>
        public int UniqueUser { get; set; }

        /// <summary>
        /// 独立访客IP
        /// </summary>
        public int UniqueIp { get; set; }

        /// <summary>
        /// 访问次数
        /// </summary>
        public int AccessNumber { get; set; }

        /// <summary>
        /// 人均浏览页数
        /// </summary>
        public float UserViewPageAverage { get; set; }

        /// <summary>
        /// 平均访问深度
        /// </summary>
        public float ViewPageDeptAverage { get; set; }

        /// <summary>
        /// 平均访问时长
        /// </summary>
        public int ViewPageTimeSpanAverage { get; set; }

        /// <summary>
        /// 跳出率
        /// </summary>
        public float BounceRate { get; set; }

    }
}
