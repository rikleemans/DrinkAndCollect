using System;
using System.Collections.Generic;
using System.Text;
using Dal.Interface;

namespace Dal.Factory
{
    public static class UserCollectionFactory
    {
        public static IUserCollection CreateUserCollectionDal()
        {
            return new UserCollectionDal();
        }
    }
}
