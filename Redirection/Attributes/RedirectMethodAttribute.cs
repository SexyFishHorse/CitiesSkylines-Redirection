namespace SexyFishHorse.CitiesSkylines.Redirection.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Method)]
    public class RedirectMethodAttribute : RedirectAttribute
    {
        public RedirectMethodAttribute() : base(false)
        {
        }

        public RedirectMethodAttribute(bool onCreated) : base(onCreated)
        {
        }
    }
}
