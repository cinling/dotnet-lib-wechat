using Cinling.Lib.Interfaces;

namespace LibWechat.Options {
    
    /// <summary>
    /// 微信api配置
    /// </summary>
    public class WechatApiOptions : ICloneWith {
        /// <summary>
        /// AppId
        /// </summary>
        public string AppId { get; set; } = "";
        /// <summary>
        /// AppSecret
        /// </summary>
        public string AppSecret { get; set; } = "";
    }
}