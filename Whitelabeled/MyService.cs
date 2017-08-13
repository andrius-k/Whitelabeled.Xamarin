using System;
namespace Whitelabeled
{
    public static class MyService
    {
#if DEVELOPMENT
		private static string environment = "Development";
#elif STAGING
        private static string environment = "Staging";
#elif PRODUCTION
        private static string environment = "Production";
#endif

        public static string GetEnvironment()
        {
            return environment;
        }
    }
}
