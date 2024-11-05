using GamataAPI.Context;
using GamataAPI.Helpers;
using GamataAPI.Model;
using GamataAPI.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IO.Compression;
using System.Security.Claims;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.Configure<BrotliCompressionProviderOptions>(options =>
        {
            options.Level = CompressionLevel.Fastest;
        });

        //set database
        builder.Services.AddDbContext<AppDbContext>(config =>
        {
            string mySqlConnectionStr = builder.Configuration.GetConnectionString("DefaultConnection");
            config.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr));

        });

        //Configuration from AppSettings
        builder.Services.Configure<JWT>(builder.Configuration.GetSection("JWT"));
        builder.Services.Configure<FormOptions>(options => options.MultipartBodyLengthLimit = long.MaxValue);

        builder.Services.AddIdentity<AppUser, IdentityRole>(config =>
        {
            config.Password.RequireDigit = false;
            config.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+/  ";
            config.Password.RequiredLength = 4;
            config.Password.RequireLowercase = false;
            config.Password.RequireNonAlphanumeric = false;
            config.Password.RequireUppercase = false;
            config.SignIn.RequireConfirmedAccount = true;
            config.Lockout.AllowedForNewUsers = true;
        })
           .AddEntityFrameworkStores<AppDbContext>()
           .AddDefaultTokenProviders();

        //builder.Services.Configure<PasswordPolicySettingsModel>(builder.Configuration.GetSection("PasswordPolicySettings"));

        builder.Services.Configure<IdentityOptions>(options =>
        {
            options.SignIn.RequireConfirmedAccount = false;
            options.SignIn.RequireConfirmedEmail = false;
            options.SignIn.RequireConfirmedPhoneNumber = false;
        });


        builder.Services.AddScoped<UserService>();
        builder.Services.AddScoped<UserRole>();



        builder.Services.AddControllers();
        builder.Services.AddCors();

        //add the following line of code
        builder.Services.AddScoped<IUserClaimsPrincipalFactory<AppUser>, MyUserClaimsPrincipalFactory>();
        //Adding Athentication - JWT
        builder.Services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })

            .AddJwtBearer(o =>
            {
                o.RequireHttpsMetadata = false;
                o.SaveToken = false;
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,

                    ValidIssuer = builder.Configuration["JWT:Issuer"],
                    ValidAudience = builder.Configuration["JWT:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]))
                };
            });

        builder.Services.Configure<IdentityOptions>(options =>
            options.ClaimsIdentity.UserIdClaimType = ClaimTypes.NameIdentifier);

        builder.Services.AddHttpContextAccessor();

        builder.Services.AddAuthorization(options =>
        {
            options.AddPolicy("EmailID", policy =>
            policy.RequireClaim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", "madushan.chamara@overleap.lk"
            ));

            options.AddPolicy("OnlyAdmin", policy =>
            policy.RequireRole("Admin", "Manager")
            );

            options.AddPolicy("OnlyUser", policy =>
            policy.RequireRole("User")
            );


        });

        builder.Services.AddMemoryCache();

        builder.Services.AddEndpointsApiExplorer();
        builder.WebHost.UseUrls("http://*:80");

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        CommonResources.System_File_Path = string.Format("{0}/uploads/", app.Environment.WebRootPath);
        app.UseStaticFiles();

        //app.UseStaticFiles(new StaticFileOptions
        //{
        //    RequestPath = "/backend"
        //});

        //app.UsePathBase("/backend");

        // Enable Serilog request logging
       app.UseCors(x => x.AllowCredentials().AllowAnyHeader().AllowAnyMethod().SetIsOriginAllowed(origin => true).AllowCredentials());
        // app.UseCors(policy => policy
        //     .WithOrigins("http://gamata-backend.aethriasolutions.com") // Specify the origin explicitly
        //     .AllowCredentials()
        //     .AllowAnyHeader()
        //     .AllowAnyMethod()
        //     );  

        app.UseHttpsRedirection();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}