using Cinling.Lib.Attributes;
using Cinling.Lib.Enums;
using Cinling.Lib.Structs.Vos;

namespace LibWechat.Structs.Oos {
    
    /// <summary>
    /// 
    /// </summary>
    [CanDictionaryClass(CanDictionary.Underscore)]
    public class BaseWechatOo : BaseVo {
        /// <summary>
        /// 错误代码
        /// </summary>
        public int Errcode { get; set; }
        
        /// <summary>
        /// 错误消息
        /// </summary>
        public string Errmsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsDone() {
            return Errcode == 0;
        }
    }
}