namespace Dapper;

public static partial class SqlMapper
{
    public static class Settings
    {
        public static bool UseSingleResultOptimization { get; set; }
        public static bool UseSingleRowOptimization { get; set; }
        public static int? CommandTimeout { get; set; }
        public static bool ApplyNullValues { get; set; }
        public static bool PadListExpansions { get; set; }
        public static int InListStringSplitCount { get; set; }
        public static bool UseIncrementalPseudoPositionalParameterNames { get; set; }
        public static long FetchSize { get; set; }
        public static bool SupportLegacyParameterTokens { get; set; }

        public static void SetDefaults()
        {
            CommandTimeout = null;
            ApplyNullValues = false;
            PadListExpansions = false;
            InListStringSplitCount = -1;
            UseIncrementalPseudoPositionalParameterNames = false;
            FetchSize = 0;
            SupportLegacyParameterTokens = true;
        }
    }
}
