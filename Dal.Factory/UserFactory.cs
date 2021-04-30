using Dal.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Factory
{
    public static class UserFactory
    {
        public static IUser CreateUserDal()
        {
            return new UserDal();
        }
    }
}

