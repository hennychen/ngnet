﻿using Furion;
using Microsoft.Extensions.DependencyInjection;

namespace ngnet.EntityFramework.Core;

public class Startup : AppStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDatabaseAccessor(options =>
        {
            options.AddDbPool<DefaultDbContext>();
        }, "ngnet.Database.Migrations");
    }
}
