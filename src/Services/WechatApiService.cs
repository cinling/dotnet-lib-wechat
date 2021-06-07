using LibWechat.Structs.Cos;

namespace LibWechat.Services {

    /// <summary>
    /// 
    /// </summary>
    public interface IWechatApiService {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public WechatApiServiceCo getCo();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="co"></param>
        /// <returns></returns>
        public WechatApiServiceCo setCo(WechatApiServiceCo co);
    }
    
    /// <summary>
    /// WeChat public account interface
    /// </summary>
    public class WechatApiService : IWechatApiService {
        /// <summary>
        /// 
        /// </summary>
        private WechatApiServiceCo _co;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public WechatApiServiceCo getCo() {
            return _co;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="co"></param>
        /// <returns></returns>
        public WechatApiServiceCo setCo(WechatApiServiceCo co) {
            _co = co;
            return _co;
        }
    }
}