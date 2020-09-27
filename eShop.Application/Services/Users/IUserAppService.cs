using Abp.Application.Services;
using Abp.Application.Services.Dto;
using eShop.Application.Services.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Application.Services.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task<ListResultDto<UserDto>> GetAll();
    }
}
