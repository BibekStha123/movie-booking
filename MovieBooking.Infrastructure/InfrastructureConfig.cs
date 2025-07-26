using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieBooking.Application.Interfaces;
using MovieBooking.Application.Services;
using MovieBooking.Domain.Interfaces;
using MovieBooking.Infrastructure.Auth;
using MovieBooking.Infrastructure.Persistence;
using MovieBooking.Infrastructure.Repositories;

namespace MovieBooking.Infrastructure
{
    public static class InfrastructureConfig
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"),
                    sql => sql.MigrationsAssembly(typeof(ApplicationDBContext).Assembly.FullName));
            });

            services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

            //repositories
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IDirectorRepository, DirectorRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            //services
            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<IDirectorService, DirectorService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
            //unit of work
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //jwt
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

            return services;
        }
    }
}
