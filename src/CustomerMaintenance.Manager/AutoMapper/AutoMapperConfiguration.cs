using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerMaintenanceManager.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration  RegisterMapper()
        {
            return new MapperConfiguration(cfg => {
                cfg.AddProfile(new CustomerProfile());
            });
        }
    }
}
