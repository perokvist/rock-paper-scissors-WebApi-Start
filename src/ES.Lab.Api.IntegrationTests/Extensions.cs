﻿using System;

namespace ES.Lab.Api.IntegrationTests
{
    public static class Extensions
    {
        public static T Tap<T>(this T self, Action<T> action)
        {
            action(self);
            return self;
        }
    }
}