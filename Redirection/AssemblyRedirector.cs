namespace SexyFishHorse.CitiesSkylines.Redirection
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Attributes;
    using Extensions;

    public class AssemblyRedirector
    {
        private static Type[] types;

        public static void Deploy()
        {
            types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetCustomAttributes(typeof(TargetTypeAttribute), false).Length > 0).ToArray();
            foreach (var type in types)
            {
                type.Redirect();
            }
        }

        public static void Revert()
        {
            if (types == null)
            {
                return;
            }
            foreach (var type in types)
            {
                type.Revert();
            }
            types = null;
        }

    }


}
