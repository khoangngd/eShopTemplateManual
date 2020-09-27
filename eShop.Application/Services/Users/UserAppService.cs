using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using eShop.Application.Services.Users.Dto;
using eShop.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace eShop.Application.Services.Users
{
    public class UserAppService : ApplicationService, IUserAppService
    {
        private readonly IRepository<User, Guid> _userRepository;
        private readonly IObjectMapper _objectMapper;

        public UserAppService(
            IRepository<User, Guid> userRepository
            , IObjectMapper objectMapper
            )
        {
            _userRepository = userRepository;
            _objectMapper = objectMapper;
        }

        public async Task<ListResultDto<UserDto>> GetAll()
        {
            var data = await _userRepository.GetAll().AsNoTracking().ToListAsync();

            var result = ObjectMapper.Map<List<UserDto>>(data);

            return new ListResultDto<UserDto>(result);

        }
    }
}
