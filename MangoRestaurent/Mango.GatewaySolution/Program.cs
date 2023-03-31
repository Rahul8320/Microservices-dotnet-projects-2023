using Microsoft.IdentityModel.Tokens;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);


// -- add authentication token
builder.Services.AddAuthentication("Bearer").AddJwtBearer("Bearer", options =>
{
    options.Authority = builder.Configuration["ServiceUrls:IdentityServer"];
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateAudience = false
    };
});

// -- add ocelot
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot(builder.Configuration);


var app = builder.Build();

//app.MapGet("/", () => "Welcome to Ocelot gateway --- From Rahul Dey!");
app.UseOcelot();

app.Run();
