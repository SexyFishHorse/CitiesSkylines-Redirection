namespace SexyFishHorse.CitiesSkylines.Redirection.Attributes
{
    using System;
    
    [AttributeUsage(AttributeTargets.Method)]
    public class RedirectReverseAttribute : RedirectAttribute
    {
        protected RedirectReverseAttribute()
        {
        }

        public RedirectReverseAttribute(bool onCreated) : base(onCreated)
        {
        }
    }
}
