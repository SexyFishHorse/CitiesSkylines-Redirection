namespace SexyFishHorse.CitiesSkylines.Redirection.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Method)]
    public class RedirectAttribute : Attribute
    {
        protected RedirectAttribute(bool onCreated = false)
        {
            OnCreated = onCreated;
        }

        public bool OnCreated { get; set; }
    }
}
