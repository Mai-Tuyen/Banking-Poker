using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingPoker_BackEnd.Entity;
using BankingPoker_BackEnd.Model;
using BankingPoker_BackEnd.Service.IRepository;
using BankingPoker_BackEnd.Service.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BankingPoker_BackEnd
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<BankPokerDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("BankPokerDb")));

            //register the Repository
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<IBuyInDetailRepository, BuyInDetailRepository>();
            services.AddScoped<ISumaryRepository, SumaryRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Player, PlayerDTO>();
                cfg.CreateMap<BuyInDetail, BuyInDetailDTO>();
                cfg.CreateMap<Sumary, SumaryDTO>();
            });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
