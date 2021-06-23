namespace LibWechat.Options {
    
    /// <summary>
    /// 微信api配置
    /// </summary>
    public class WechatApiOptions {
        /// <summary>
        /// AppId
        /// </summary>
        public string AppId { get; set; } = "";
        /// <summary>
        /// AppSecret
        /// </summary>
        public string AppSecret { get; set; } = "";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public void Reset(WechatApiOptions options) {
            AppId = options.AppId;
            AppSecret = options.AppSecret;
        }
    }
}