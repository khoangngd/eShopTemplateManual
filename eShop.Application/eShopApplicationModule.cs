using Abp.AutoMapper;
using Abp.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Application
{
    [DependsOn(/*typeof(TourLandCoreModule),*/ typeof(AbpAutoMapperModule))]
    public class eShopApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            // TODO: Is there somewhere else to store these, with the dto classes
            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                //// Role and permission
                //cfg.CreateMap<Permission, string>().ConvertUsing(r => r.Name);
                //cfg.CreateMap<RolePermissionSetting, string>().ConvertUsing(r => r.Name);

                //cfg.CreateMap<CreateRoleDto, Role>();
                //cfg.CreateMap<RoleDto, Role>();
                //cfg.CreateMap<Role, RoleDto>().ForMember(x => x.GrantedPermissions,
                //    opt => opt.MapFrom(x => x.Permissions.Where(p => p.IsGranted)));

                //cfg.CreateMap<UserDto, User>();
                //cfg.CreateMap<UserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());

                //cfg.CreateMap<CreateUserDto, User>();
                //cfg.CreateMap<CreateUserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());
            });
        }
    }
}
