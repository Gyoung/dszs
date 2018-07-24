using System;
using System.Collections.Generic;
using System.Text;

namespace LeafSoft.Model
{
    public class Command
    {
        /// <summary>
        /// 波特率
        /// </summary>
        public string Ptl { get; set; }

        /// <summary>
        /// com端口
        /// </summary>
        public string Com { get; set; }

        /// <summary>
        /// 数据位
        /// </summary>
        public string Sjw { get; set; }

        /// <summary>
        /// 校检位
        /// </summary>
        public string Xjw { get; set; }

        /// <summary>
        /// 停止位
        /// </summary>
        public string Tzw { get; set; }


    }
}
