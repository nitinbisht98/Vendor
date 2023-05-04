using Vendor.API.Injectable;
using Vendor.Repository.Login;
using Vendor.Services.Login;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ILoginService, LoginService>();
builder.Services.AddTransient<ILoginRepository, LoginRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//#region Dependency Injection
//InjectableServices.Services(builder);
//#endregion Dependancy Injection end

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
