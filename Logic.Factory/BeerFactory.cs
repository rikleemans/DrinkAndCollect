﻿using Logic.Interface;
using System;
using Logic;

namespace Logic.Factory
{
    public static class BeerFactory
    {
        public static IReadBeer CreateBeerLogic()
        {
            return new Beer();
        }
    }
}