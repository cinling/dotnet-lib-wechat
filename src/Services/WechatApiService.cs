
using LibWechat.Options;
using Microsoft.Extensions.Options;

namespace LibWechat.Services {

    /// <summary>
    /// 
    /// </summary>
    public interface IWechatApiService {

    }
    
    /// <summary>
    /// 微信公众号服务
    /// </summary>
    public class WechatApiService : IWechatApiService {
        /// <summary>
        /// 
        /// </summary>
        private readonly WechatApiOptions options;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public WechatApiService(IOptions<WechatApiOptions> options) {
            this.options = options.Value;
        }
    }
}