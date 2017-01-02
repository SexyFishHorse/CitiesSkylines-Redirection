﻿namespace SexyFishHorse.CitiesSkylines.Redirection.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Method)]
    internal class RedirectAttribute : Attribute
    {
        protected RedirectAttribute(bool onCreated = false)
        {
            OnCreated = onCreated;
        }

        public bool OnCreated { get; set; }
    }
}
