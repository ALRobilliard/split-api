using AutoMapper;
using SplitApi.Dtos;
using SplitApi.Models;

namespace SplitApi.Helpers
{
  public class AutoMapperProfile : Profile
  {
    public AutoMapperProfile()
    {
      CreateMap<Account, AccountDto>();
      CreateMap<AccountDto, Account>();
      CreateMap<User, UserDto>();
      CreateMap<UserDto, User>();
    }
  }
}