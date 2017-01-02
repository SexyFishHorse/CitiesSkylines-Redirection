namespace SexyFishHorse.CitiesSkylines.Redirection.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Method)]
    public class RedirectMethodAttribute : RedirectAttribute
    {
        public RedirectMethodAttribute()
        {
        }

        public RedirectMethodAttribute(bool onCreated) : base(onCreated)
        {
        }
    }
}
