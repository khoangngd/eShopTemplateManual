using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using eShop.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Application.Services.Users.Dto
{
    [AutoMapTo(typeof(User))]
    public class UserInputDto : EntityDto<Guid?>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
