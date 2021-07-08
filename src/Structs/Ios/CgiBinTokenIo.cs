using Cinling.Lib.Attributes;
using Cinling.Lib.Enums;
using Cinling.Lib.Structs.Ios;

namespace LibWechat.Structs.Ios {
    
    /// <summary>
    /// 
    /// </summary>
    [CanDictionaryClass(CanDictionary.Underscore)]
    public class CgiBinTokenIo : BaseIo {
        public string GrantType { get; set; }
        public string Appid { get; set; }
        public string Secret { get; set; }
    }
}