using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CallServersModel
{

    public class CallMessageInfo
    {
        /// <summary>
        /// 当前患者
        /// </summary>
        public string CurrentPatientName { get; set; }
        /// <summary>
        /// 下一位患者
        /// </summary>
        public string NextPatientName { get; set; }
        /// <summary>
        /// 等待人数
        /// </summary>
        public int WaitPatientCount { get; set; }
        /// <summary>
        /// 日程类型
        /// </summary>
        public string AppointmentType { get; set; }

    }
}