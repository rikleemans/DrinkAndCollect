using Logic.Interface;
using System;
using Logic;

namespace Logic.Factory
{
    public static class UserFactory
    {
        public static IReadUser CreateUserLogic()
        {
            return new User();
        }
    }
}
