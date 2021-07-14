
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using LibWechat.Constants;
using LibWechat.Options;
using LibWechat.Structs.Ios;
using LibWechat.Structs.Oos;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="io"></param>
        /// <returns></returns>
        public async Task<CgiBinTokenOo> RequestCgiBinToken(CgiBinTokenIo io) {
            var client = CreateClient();
            var response = await client.GetStringAsync(WechatUrl.CgiBinToken);
            var oo = new CgiBinTokenOo();
            oo.SetByJson(response);
            return oo;
        }

        protected HttpClient CreateClient() {
            var client = httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(options.Domain);
            return client;
        }
    }
}