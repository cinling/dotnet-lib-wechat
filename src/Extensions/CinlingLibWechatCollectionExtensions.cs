
using System;
using Cinling.Lib.Interfaces;
using LibWechat.Options;
using LibWechat.Services;
using Microsoft.Extensions.DependencyInjection;

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
        public static IServiceCollection AddWechatApiServiceScoped(this IServiceCollection services) => AddWechatApiServiceScoped(services, new WechatApiOptions());

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static IServiceCollection AddWechatApiServiceScoped(this IServiceCollection services, WechatApiOptions options) => AddWechatApiServiceScoped(services, originOptions => {
            originOptions.CloneWith(options);
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