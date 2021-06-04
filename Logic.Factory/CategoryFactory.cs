using Logic.Interface;
using System;
using Logic;

namespace Logic.Factory
{
    public static class CategoryFactory
    {
        public static IReadCategory CreateCategoryLogic()
        {
            return new Category();
        }
    }
}
