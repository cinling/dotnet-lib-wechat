
namespace LibWechat.Structs.Cos {
    
    /// <summary>
    /// <see cref="LibWechat.Services.WechatApiService"></see>
    /// </summary>
    public class WechatApiServiceCo {
        public string appId { get; }
        public string appSecret { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="appSecret"></param>
        public WechatApiServiceCo(string appId, string appSecret) {
            this.appId = appId;
            this.appSecret = appSecret;
        }
    }
}