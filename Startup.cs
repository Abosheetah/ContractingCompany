using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContractingCompany.Models.CCDBContextFld;
using ContractingCompany.Models.Office.CareerFld;
using ContractingCompany.Models.Office.EmployeeFld;
using ContractingCompany.Models.PublicItems.EquipmentFld;
using ContractingCompany.Models.PublicItems.ProductFld;
using ContractingCompany.Models.PublicItems.SupplierFld;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ContractingCompany
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CCDBContext>(options => options.UseSqlServer(Configuration["Data:ContractingCompany:ConnectionString"]));
            services.AddTransient<ICareerType,CareerTypeEF>();
            services.AddTransient<ICareer,CareerEF>();
            services.AddTransient<IEmployee,EmployeeEF>();
            services.AddTransient<ISupplierCategory,SupplierCategoryEF>();
            services.AddTransient<ISupplier,SupplierEF>();
            services.AddTransient<IProductCategory,ProductCategoryEF>();
            services.AddTransient<IProduct,ProductEF>();
            services.AddTransient<IEquipmentType,EquipmentTypeEF>();
            services.AddMvc();
            
        }
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseMvc(routes => {
                routes.MapRoute(
                name: "default",
                template: "{controller=CareerType}/{action=List}/{id?}");
            });
        }
    }
}
