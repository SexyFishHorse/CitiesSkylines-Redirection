namespace SexyFishHorse.CitiesSkylines.Redirection.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Method)]
    public class RedirectReverseAttribute : RedirectAttribute
    {
        public RedirectReverseAttribute() : base(false)
        {
        }

        public RedirectReverseAttribute(bool onCreated) : base(onCreated)
        {
        }
    }
}