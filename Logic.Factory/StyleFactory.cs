using Logic.Interface;
using System;
using Logic;

namespace Logic.Factory
{
    public static class StyleFactory
    {
        public static IReadStyle CreateStyleLogic()
        {
            return new Style();
        }
    }
}
