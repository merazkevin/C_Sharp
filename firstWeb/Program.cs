var builder = WebApplication.CreateBuilder(args);
//services bropught in before you build 
builder.Services.AddControllesWithVies();
var app = builder.Build();

//bring in some features for our app
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

//tell our project to run using the contorller
app.MapControllerRoute(    
    name: "default",    
    pattern: "{controller=Home}/{action=Index}/{id?}");


//thisis always the last Line
app.Run();
