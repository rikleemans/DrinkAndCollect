using Logic.Interface;
using System;
using Logic;

namespace Logic.Factory
{
    public static class UserCollectionFactory
    {
        public static IReadUserCollection CreateUserCollectionLogic()
        {
            return new UserCollection();
        }
    }
}
