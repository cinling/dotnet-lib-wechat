using Cinling.Lib.Attributes;
using Cinling.Lib.Enums;
using Cinling.Lib.Structs.Ios;

namespace LibWechat.Structs.Ios {
    
    /// <summary>
    /// 
    /// </summary>
    [CanDictionaryClass(CanDictionary.Underscore)]
    public class CgiBinTokenIo : BaseIo {
        
        /// <summary>
        /// 
        /// </summary>
        public string GrantType { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Appid { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Secret { get; set; }
    }
}