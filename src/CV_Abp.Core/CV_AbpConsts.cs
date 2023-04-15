using CV_Abp.Debugging;

namespace CV_Abp
{
    public class CV_AbpConsts
    {
        public const string LocalizationSourceName = "CV_Abp";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "a455e545c9f241b98288cc82ba487820";
    }
}
