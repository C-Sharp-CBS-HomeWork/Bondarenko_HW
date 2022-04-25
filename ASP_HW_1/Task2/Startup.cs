using Microsoft.AspNetCore.Builder;

namespace Task2
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                        name: "Default",
                        pattern: "{controller}/{action}/{id:int?}"
                    );
            });

            // {id?} - данный фрагмент шаблона описывает не обязательный сегмент в адресе запроса.
            // При этом в контроллерах по имени id можно будет получить информацию, которая пришла в запросе
            // Products/Details/10
            // {controller} = Products
            // {action} = Details
            // {id} = 10
        }
    }
}
