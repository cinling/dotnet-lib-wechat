namespace LibWechat.Structs.Ios {
    
    /// <summary>
    /// 
    /// </summary>
    public class CheckSignatureIn {
        /// <summary>
        /// 微信加密签名，signature结合了开发者填写的token参数和请求中的timestamp参数、nonce参数。
        /// </summary>
        public string signature { get; set; }

        /// <summary>
        /// 時間戳
        /// </summary>
        public int timestamp { get; set; }
        /// <summary>
        /// 隨機數
        /// </summary>
        public string nonce { get; set; }
        /// <summary>
        /// 隨機字符串
        /// </summary>
        public string echostr { get; set; }
    }
}