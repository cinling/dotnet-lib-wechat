
using System.Net.Http;
using LibWechat.Constants;
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
        protected readonly WechatApiOptions options;
        /// <summary>
        /// 
        /// </summary>
        protected readonly IHttpClientFactory httpClientFactory;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iOptions"></param>
        /// <param name="iHttpClientFactory"></param>
        public WechatApiService(IOptions<WechatApiOptions> iOptions, IHttpClientFactory iHttpClientFactory) {
            options = iOptions.Value;
            httpClientFactory = iHttpClientFactory;
        }
    }
}