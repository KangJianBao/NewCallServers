using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CallServersModel
{
    public class ConfigInfo
    {
        #region 服务器设置
        public class ServerInfo
        {
            /// <summary>
            /// 服务器IP
            /// </summary>
            public string ServerIP { get; set; }
            /// <summary>
            /// 端口号
            /// </summary>
            public string ServerPort { get; set; }
        }
        #endregion

        #region 语音设置
        public class SpeechInfo
        {
            /// <summary>
            /// 播音人
            /// </summary>
            public string SelectVoice { get; set; }
            /// <summary>
            /// 音量
            /// </summary>
            public string Value { get; set; }
            /// <summary>
            /// 语速
            /// </summary>
            public string Rate { get; set; }
        }
        #endregion

        #region 日期时间设置
        public class DateTimeViewInfo
        {
            /// <summary>
            /// 字体颜色
            /// </summary>
            public string ForeColor { get; set; }
            /// <summary>
            /// 字体
            /// </summary>
            public string FontName { get; set; }
            /// <summary>
            /// 字体大小
            /// </summary>
            public string FontSize { get; set; }
            /// <summary>
            /// 是否加粗显示
            /// </summary>
            public string Bold { get; set; }

        }
        #endregion

        #region 标题设置
        public class TitleViewInfo
        {
            /// <summary>
            /// 字体颜色
            /// </summary>
            public string ForeColor { get; set; }
            /// <summary>
            /// 字体
            /// </summary>
            public string FontName { get; set; }
            /// <summary>
            /// 字体大小
            /// </summary>
            public string FontSize { get; set; }
            /// <summary>
            /// 是否加粗显示
            /// </summary>
            public string Bold { get; set; }
            /// <summary>
            /// 显示文本
            /// </summary>
            public string Text { get; set; }

        }
        #endregion

        #region 当前患者设置
        public class CurrentPatientViewInfo
        {
            /// <summary>
            /// 字体颜色
            /// </summary>
            public string ForeColor { get; set; }
            /// <summary>
            /// 字体
            /// </summary>
            public string FontName { get; set; }
            /// <summary>
            /// 字体大小
            /// </summary>
            public string FontSize { get; set; }
            /// <summary>
            /// 是否加粗显示
            /// </summary>
            public string Bold { get; set; }

            /// <summary>
            /// 是否显示
            /// </summary>
            public string Visible { get; set; }
        }
        #endregion

        #region 准备患者设置
        public class NextPatientViewInfo
        {
            /// <summary>
            /// 字体颜色
            /// </summary>
            public string ForeColor { get; set; }
            /// <summary>
            /// 字体
            /// </summary>
            public string FontName { get; set; }
            /// <summary>
            /// 字体大小
            /// </summary>
            public string FontSize { get; set; }
            /// <summary>
            /// 是否加粗显示
            /// </summary>
            public string Bold { get; set; }

            /// <summary>
            /// 是否显示
            /// </summary>
            public string Visible { get; set; }
        }
        #endregion

        public class APlayerInfo
        {
            /// <summary>
            /// Aplayer播放的文件路径
            /// </summary>
            public string FilePath { get; set; }
            public string Logo { get; set; }
        }
    }
}
