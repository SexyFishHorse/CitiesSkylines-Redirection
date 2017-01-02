namespace SexyFishHorse.CitiesSkylines.Redirection
{
    using Extensions;

    public class Redirector<T>
    {
        public static void Deploy()
        {
            typeof(T).Redirect();
        }

        public static bool IsDeployed()
        {
            return typeof(T).IsRedirected();
        }

        public static void Revert()
        {
            typeof(T).Revert();
        }
    }
}
