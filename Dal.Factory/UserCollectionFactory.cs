using Dal.Interface;
using System;
using System.Collections.Generic;
using System.Text;

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
