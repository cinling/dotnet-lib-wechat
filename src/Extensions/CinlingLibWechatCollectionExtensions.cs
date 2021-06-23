
using System;
using LibWechat.Options;
using LibWechat.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace LibWechat.Extensions {
    
    /// <summary>
    /// 
    /// </summary>
    public static class CinlingLibWechatCollectionExtensions {
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddWechatApiServiceScoped(this IServiceCollection services) {
            return services;
        }

        public static IServiceCollection AddWechatApiServiceScoped(this IServiceCollection services, WechatApiOptions options) => AddWechatApiServiceScoped(services, originOptions => {
            originOptions.Reset(options);
        });

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="optionsAction"></param>
        /// <returns></returns>
        public static IServiceCollection AddWechatApiServiceScoped(this IServiceCollection services, Action<WechatApiOptions> optionsAction) {
            services.AddOptions();
            services.AddOptions<WechatApiOptions>().Configure(optionsAction);
            services.AddScoped<IWechatApiService, WechatApiService>();
            return services;
        }
    }
}