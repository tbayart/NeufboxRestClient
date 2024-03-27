using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using NeufboxRestClient.Interfaces;
using NeufboxRestClient.Models;

namespace NeufboxRestClient
{
    /// <summary>
    /// Helper methods to setup the library with dependency injection.
    /// </summary>
    public static class DependencyInjectionHelpers
    {
        /// <summary>
        /// Default path to map the <see cref="NeufboxSettings"/>.
        /// </summary>
        public const string defaultNeufboxSettingsPath = "NeufboxSettings";

        /// <summary>
        /// Setup dependency injection from <see cref="IHostBuilder"/>.
        /// </summary>
        /// <param name="hostBuilder">A <see cref="IHostBuilder"/> instance.</param>
        /// <param name="neufboxSettingsPath">The path to the client settings.</param>
        /// <returns>The original <see cref="IHostBuilder"/> instance.</returns>
        public static IHostBuilder UseNeuboxClient(this IHostBuilder hostBuilder, string neufboxSettingsPath = defaultNeufboxSettingsPath)
        {
            return hostBuilder.ConfigureServices((hostBuilderContext, services)
                => services.UseNeuboxClient(hostBuilderContext.Configuration, neufboxSettingsPath));
        }

        /// <summary>
        /// Setup dependency injection from <see cref="IHostApplicationBuilder"/>.
        /// </summary>
        /// <param name="hostApplicationBuilder">A <see cref="IHostApplicationBuilder"/> instance.</param>
        /// <param name="neufboxSettingsPath">The path to the client settings.</param>
        /// <returns>The original <see cref="IHostApplicationBuilder"/> instance.</returns>
        public static IHostApplicationBuilder UseNeufboxClient(this IHostApplicationBuilder hostApplicationBuilder, string neufboxSettingsPath = defaultNeufboxSettingsPath)
        {
            hostApplicationBuilder.Services.UseNeuboxClient(hostApplicationBuilder.Configuration, neufboxSettingsPath);
            return hostApplicationBuilder;
        }

        /// <summary>
        /// Setup dependency injection from <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">A <see cref="IServiceCollection"/> instance.</param>
        /// <param name="configuration">A <see cref="IConfiguration"/> instance.</param>
        /// <param name="neufboxSettingsPath">The path to the client settings.</param>
        /// <returns>The original <see cref="IServiceCollection"/> instance.</returns>
        public static IServiceCollection UseNeuboxClient(this IServiceCollection services, IConfiguration configuration, string neufboxSettingsPath = defaultNeufboxSettingsPath)
        {
            var section = configuration.GetSection(neufboxSettingsPath);
            services.AddHttpClient<NeufboxClient>(ConfigureHttpClient);
            return services.Configure<NeufboxSettings>(section)
                .AddSingleton<INeufboxClient, NeufboxClient>()
                .AddTransient<IHashProcessor, HashProcessor>()
                .AddTransient<IRequestMessageBuilder, RequestMessageBuilder>()
                .AddTransient<IApiResponseDeserializer, ApiResponseDeserializerXml>();
        }

        private static void ConfigureHttpClient(IServiceProvider provider, HttpClient client)
        {
            var settings = provider.GetRequiredService<IOptions<NeufboxSettings>>().Value;
            var uriBuilder = new UriBuilder(settings.Scheme, settings.Host, -1, settings.ApiPath);
            client.BaseAddress = uriBuilder.Uri;
        }
    }
}
