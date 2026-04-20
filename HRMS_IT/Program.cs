using ApiConnect.Services.Attendance;
using ApiConnect.Services.Employees;
using ApiConnect.Services.Payroll;
using Rotativa.AspNetCore;

namespace HRMS_IT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //builder.Services.AddRazorPages();
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<DbHelper>();
            builder.Services.AddHostedService<DbUpdateService>();

            // API URL
            builder.Services.AddHttpClient<EmployeeService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:5001/"); // your API
            });
            // API URL
            builder.Services.AddHttpClient<PayrollService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:5001/"); // your API
            });
            builder.Services.AddHttpClient<AttendanceService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:5001/");// your API
            });

            var app = builder.Build();


            // for download Pdf
            RotativaConfiguration.Setup(app.Environment.WebRootPath, "Rotativa");

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                //app.UseExceptionHandler("/Error");
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            //for static file
            app.UseStaticFiles();
            app.UseRouting();


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            //app.MapRazorPages().WithStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Attendance}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
