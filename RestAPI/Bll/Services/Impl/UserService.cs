using Bll.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services.Impl
{
	public class UserService : IUserService
	{
		public UserDto CreateUser(UserDto user)
		{
			return user;
		}

		public UserDto GetUserById(int id)
		{
			return new UserDto()
			{
				ID = id,
			};
		}

		public void UpdateUser(int id, UserDto user)
		{
			
		}
	}
}
