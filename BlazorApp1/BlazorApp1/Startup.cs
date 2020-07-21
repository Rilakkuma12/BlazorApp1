using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlazorApp1.Data;
using APLActions;
using Microsoft.Extensions.Logging;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using BlazorApp1.Data.kafka;
using APLKafka;
using APLKafka.kafka;
using Microsoft.JSInterop;

namespace BlazorApp1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        //public IJSRuntime JSRuntime { get; }
        public ILogger<T> logger { get; set; }
        

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler((o, e) =>
            {
                logger.Error($"Unhandled Exception.{e.ExceptionObject}");
            });
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddSingleton<ReceiveKafkaService>();
            services.AddSingleton<KafkaProducer>();
            services.AddSingleton<KafkaConsumer>();
            services.AddSingleton<AplQuery>();
            services.AddSingleton<AplScan>();
            //services.AddSingleton<KafkaSetting>();
            KafkaSetting _kafkaSetting = new KafkaSetting();
            Configuration.GetSection("KafkaSetting").Bind(_kafkaSetting);
            services.AddSingleton<KafkaSetting>(_kafkaSetting);
            //services.AddSingleton<JSRuntime>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //BlazorApp1 -- signalR
                endpoints.MapBlazorHub();
                // ≈‰÷√∏˘“≥√Ê
                endpoints.MapFallbackToPage("/_Host");
            });
        }
        private void ConfigureDependencyInject(IServiceCollection services)
        {
            services.AddTransient<IAplLogsService, IAplLogsService>();
        }
    }
}
