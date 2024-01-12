// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace System.Globalization.Tests
{
    public class DateTimeFormatInfoGetEraName
    {
        public static IEnumerable<object[]> GetEraName_TestData()
        {
            yield return new object[] { "invariant", 1, "A.D." };
            yield return new object[] { "invariant", 0, "A.D." };

            if (!PlatformDetection.IsHybridGlobalizationOnBrowser)
            {
                var enUS = "en-US";
                yield return new object[] { enUS, 1, DateTimeFormatInfoData.EnUSEraName() };
                yield return new object[] { enUS, 0, DateTimeFormatInfoData.EnUSEraName() };

                var frFR = "fr-FR";
                yield return new object[] { frFR, 1, "ap. J.-C." };
                yield return new object[] { frFR, 0, "ap. J.-C." };
            }
            else
            {
                yield return new object[] { "ar-SA", 0, "بعد الهجرة" };
                yield return new object[] { "ar-SA", 1, "بعد الهجرة" };
                yield return new object[] { "am-ET", 0, "ዓ/ም" };
                yield return new object[] { "am-ET", 1, "ዓ/ም" };
                yield return new object[] { "bg-BG", 0, "сл.Хр." };
                yield return new object[] { "bg-BG", 1, "сл.Хр." };
                yield return new object[] { "bn-BD", 0, "খৃষ্টাব্দ" };
                yield return new object[] { "bn-BD", 1, "খৃষ্টাব্দ" };
                yield return new object[] { "bn-IN", 0, "খ্রিঃ" };
                yield return new object[] { "bn-IN", 1, "খ্রিঃ" };
                yield return new object[] { "ca-AD", 0, "dC" };
                yield return new object[] { "ca-AD", 1, "dC" };
                yield return new object[] { "ca-ES", 0, "dC" };
                yield return new object[] { "ca-ES", 1, "dC" };
                yield return new object[] { "cs-CZ", 0, "n. l." };
                yield return new object[] { "cs-CZ", 1, "n. l." };
                yield return new object[] { "da-DK", 0, "e.Kr." };
                yield return new object[] { "da-DK", 1, "e.Kr." };
                yield return new object[] { "de-AT", 0, "n. Chr." };
                yield return new object[] { "de-AT", 1, "n. Chr." };
                yield return new object[] { "de-BE", 0, "n. Chr." };
                yield return new object[] { "de-BE", 1, "n. Chr." };
                yield return new object[] { "de-CH", 0, "n. Chr." };
                yield return new object[] { "de-CH", 1, "n. Chr." };
                yield return new object[] { "de-DE", 0, "n. Chr." };
                yield return new object[] { "de-DE", 1, "n. Chr." };
                yield return new object[] { "de-IT", 0, "n. Chr." };
                yield return new object[] { "de-IT", 1, "n. Chr." };
                yield return new object[] { "de-LI", 0, "n. Chr." };
                yield return new object[] { "de-LI", 1, "n. Chr." };
                yield return new object[] { "de-LU", 0, "n. Chr." };
                yield return new object[] { "de-LU", 1, "n. Chr." };
                yield return new object[] { "el-CY", 0, "μ.Χ." };
                yield return new object[] { "el-CY", 1, "μ.Χ." };
                yield return new object[] { "el-GR", 0, "μ.Χ." };
                yield return new object[] { "el-GR", 1, "μ.Χ." };
                yield return new object[] { "en-AE", 0, "AD" };
                yield return new object[] { "en-AE", 1, "AD" };
                yield return new object[] { "en-AG", 0, "AD" };
                yield return new object[] { "en-AG", 1, "AD" };
                yield return new object[] { "en-AI", 0, "AD" };
                yield return new object[] { "en-AI", 1, "AD" };
                yield return new object[] { "en-AS", 0, "AD" };
                yield return new object[] { "en-AS", 1, "AD" };
                yield return new object[] { "en-AT", 0, "AD" };
                yield return new object[] { "en-AT", 1, "AD" };
                yield return new object[] { "en-AU", 0, "AD" };
                yield return new object[] { "en-AU", 1, "AD" };
                yield return new object[] { "en-BB", 0, "AD" };
                yield return new object[] { "en-BB", 1, "AD" };
                yield return new object[] { "en-BE", 0, "AD" };
                yield return new object[] { "en-BE", 1, "AD" };
                yield return new object[] { "en-BI", 0, "AD" };
                yield return new object[] { "en-BI", 1, "AD" };
                yield return new object[] { "en-BM", 0, "AD" };
                yield return new object[] { "en-BM", 1, "AD" };
                yield return new object[] { "en-BS", 0, "AD" };
                yield return new object[] { "en-BS", 1, "AD" };
                yield return new object[] { "en-BW", 0, "AD" };
                yield return new object[] { "en-BW", 1, "AD" };
                yield return new object[] { "en-BZ", 0, "AD" };
                yield return new object[] { "en-BZ", 1, "AD" };
                yield return new object[] { "en-CA", 0, "AD" };
                yield return new object[] { "en-CA", 1, "AD" };
                yield return new object[] { "en-CC", 0, "AD" };
                yield return new object[] { "en-CC", 1, "AD" };
                yield return new object[] { "en-CH", 0, "AD" };
                yield return new object[] { "en-CH", 1, "AD" };
                yield return new object[] { "en-CK", 0, "AD" };
                yield return new object[] { "en-CK", 1, "AD" };
                yield return new object[] { "en-CM", 0, "AD" };
                yield return new object[] { "en-CM", 1, "AD" };
                yield return new object[] { "en-CX", 0, "AD" };
                yield return new object[] { "en-CX", 1, "AD" };
                yield return new object[] { "en-CY", 0, "AD" };
                yield return new object[] { "en-CY", 1, "AD" };
                yield return new object[] { "en-DE", 0, "AD" };
                yield return new object[] { "en-DE", 1, "AD" };
                yield return new object[] { "en-DK", 0, "AD" };
                yield return new object[] { "en-DK", 1, "AD" };
                yield return new object[] { "en-DM", 0, "AD" };
                yield return new object[] { "en-DM", 1, "AD" };
                yield return new object[] { "en-ER", 0, "AD" };
                yield return new object[] { "en-ER", 1, "AD" };
                yield return new object[] { "en-FI", 0, "AD" };
                yield return new object[] { "en-FI", 1, "AD" };
                yield return new object[] { "en-FJ", 0, "AD" };
                yield return new object[] { "en-FJ", 1, "AD" };
                yield return new object[] { "en-FK", 0, "AD" };
                yield return new object[] { "en-FK", 1, "AD" };
                yield return new object[] { "en-FM", 0, "AD" };
                yield return new object[] { "en-FM", 1, "AD" };
                yield return new object[] { "en-GB", 0, "AD" };
                yield return new object[] { "en-GB", 1, "AD" };
                yield return new object[] { "en-GD", 0, "AD" };
                yield return new object[] { "en-GD", 1, "AD" };
                yield return new object[] { "en-GG", 0, "AD" };
                yield return new object[] { "en-GG", 1, "AD" };
                yield return new object[] { "en-GH", 0, "AD" };
                yield return new object[] { "en-GH", 1, "AD" };
                yield return new object[] { "en-GI", 0, "AD" };
                yield return new object[] { "en-GI", 1, "AD" };
                yield return new object[] { "en-GM", 0, "AD" };
                yield return new object[] { "en-GM", 1, "AD" };
                yield return new object[] { "en-GU", 0, "AD" };
                yield return new object[] { "en-GU", 1, "AD" };
                yield return new object[] { "en-GY", 0, "AD" };
                yield return new object[] { "en-GY", 1, "AD" };
                yield return new object[] { "en-HK", 0, "AD" };
                yield return new object[] { "en-HK", 1, "AD" };
                yield return new object[] { "en-IE", 0, "AD" };
                yield return new object[] { "en-IE", 1, "AD" };
                yield return new object[] { "en-IL", 0, "AD" };
                yield return new object[] { "en-IL", 1, "AD" };
                yield return new object[] { "en-IM", 0, "AD" };
                yield return new object[] { "en-IM", 1, "AD" };
                yield return new object[] { "en-IN", 0, "AD" };
                yield return new object[] { "en-IN", 1, "AD" };
                yield return new object[] { "en-IO", 0, "AD" };
                yield return new object[] { "en-IO", 1, "AD" };
                yield return new object[] { "en-JE", 0, "AD" };
                yield return new object[] { "en-JE", 1, "AD" };
                yield return new object[] { "en-JM", 0, "AD" };
                yield return new object[] { "en-JM", 1, "AD" };
                yield return new object[] { "en-KE", 0, "AD" };
                yield return new object[] { "en-KE", 1, "AD" };
                yield return new object[] { "en-KI", 0, "AD" };
                yield return new object[] { "en-KI", 1, "AD" };
                yield return new object[] { "en-KN", 0, "AD" };
                yield return new object[] { "en-KN", 1, "AD" };
                yield return new object[] { "en-KY", 0, "AD" };
                yield return new object[] { "en-KY", 1, "AD" };
                yield return new object[] { "en-LC", 0, "AD" };
                yield return new object[] { "en-LC", 1, "AD" };
                yield return new object[] { "en-LR", 0, "AD" };
                yield return new object[] { "en-LR", 1, "AD" };
                yield return new object[] { "en-LS", 0, "AD" };
                yield return new object[] { "en-LS", 1, "AD" };
                yield return new object[] { "en-MG", 0, "AD" };
                yield return new object[] { "en-MG", 1, "AD" };
                yield return new object[] { "en-MH", 0, "AD" };
                yield return new object[] { "en-MH", 1, "AD" };
                yield return new object[] { "en-MO", 0, "AD" };
                yield return new object[] { "en-MO", 1, "AD" };
                yield return new object[] { "en-MP", 0, "AD" };
                yield return new object[] { "en-MP", 1, "AD" };
                yield return new object[] { "en-MS", 0, "AD" };
                yield return new object[] { "en-MS", 1, "AD" };
                yield return new object[] { "en-MT", 0, "AD" };
                yield return new object[] { "en-MT", 1, "AD" };
                yield return new object[] { "en-MU", 0, "AD" };
                yield return new object[] { "en-MU", 1, "AD" };
                yield return new object[] { "en-MW", 0, "AD" };
                yield return new object[] { "en-MW", 1, "AD" };
                yield return new object[] { "en-MY", 0, "AD" };
                yield return new object[] { "en-MY", 1, "AD" };
                yield return new object[] { "en-NA", 0, "AD" };
                yield return new object[] { "en-NA", 1, "AD" };
                yield return new object[] { "en-NF", 0, "AD" };
                yield return new object[] { "en-NF", 1, "AD" };
                yield return new object[] { "en-NG", 0, "AD" };
                yield return new object[] { "en-NG", 1, "AD" };
                yield return new object[] { "en-NL", 0, "AD" };
                yield return new object[] { "en-NL", 1, "AD" };
                yield return new object[] { "en-NR", 0, "AD" };
                yield return new object[] { "en-NR", 1, "AD" };
                yield return new object[] { "en-NU", 0, "AD" };
                yield return new object[] { "en-NU", 1, "AD" };
                yield return new object[] { "en-NZ", 0, "AD" };
                yield return new object[] { "en-NZ", 1, "AD" };
                yield return new object[] { "en-PG", 0, "AD" };
                yield return new object[] { "en-PG", 1, "AD" };
                yield return new object[] { "en-PH", 0, "AD" };
                yield return new object[] { "en-PH", 1, "AD" };
                yield return new object[] { "en-PK", 0, "AD" };
                yield return new object[] { "en-PK", 1, "AD" };
                yield return new object[] { "en-PN", 0, "AD" };
                yield return new object[] { "en-PN", 1, "AD" };
                yield return new object[] { "en-PR", 0, "AD" };
                yield return new object[] { "en-PR", 1, "AD" };
                yield return new object[] { "en-PW", 0, "AD" };
                yield return new object[] { "en-PW", 1, "AD" };
                yield return new object[] { "en-RW", 0, "AD" };
                yield return new object[] { "en-RW", 1, "AD" };
                yield return new object[] { "en-SB", 0, "AD" };
                yield return new object[] { "en-SB", 1, "AD" };
                yield return new object[] { "en-SC", 0, "AD" };
                yield return new object[] { "en-SC", 1, "AD" };
                yield return new object[] { "en-SD", 0, "AD" };
                yield return new object[] { "en-SD", 1, "AD" };
                yield return new object[] { "en-SE", 0, "AD" };
                yield return new object[] { "en-SE", 1, "AD" };
                yield return new object[] { "en-SG", 0, "AD" };
                yield return new object[] { "en-SG", 1, "AD" };
                yield return new object[] { "en-SH", 0, "AD" };
                yield return new object[] { "en-SH", 1, "AD" };
                yield return new object[] { "en-SI", 0, "AD" };
                yield return new object[] { "en-SI", 1, "AD" };
                yield return new object[] { "en-SL", 0, "AD" };
                yield return new object[] { "en-SL", 1, "AD" };
                yield return new object[] { "en-SS", 0, "AD" };
                yield return new object[] { "en-SS", 1, "AD" };
                yield return new object[] { "en-SX", 0, "AD" };
                yield return new object[] { "en-SX", 1, "AD" };
                yield return new object[] { "en-SZ", 0, "AD" };
                yield return new object[] { "en-SZ", 1, "AD" };
                yield return new object[] { "en-TC", 0, "AD" };
                yield return new object[] { "en-TC", 1, "AD" };
                yield return new object[] { "en-TK", 0, "AD" };
                yield return new object[] { "en-TK", 1, "AD" };
                yield return new object[] { "en-TO", 0, "AD" };
                yield return new object[] { "en-TO", 1, "AD" };
                yield return new object[] { "en-TT", 0, "AD" };
                yield return new object[] { "en-TT", 1, "AD" };
                yield return new object[] { "en-TV", 0, "AD" };
                yield return new object[] { "en-TV", 1, "AD" };
                yield return new object[] { "en-TZ", 0, "AD" };
                yield return new object[] { "en-TZ", 1, "AD" };
                yield return new object[] { "en-UG", 0, "AD" };
                yield return new object[] { "en-UG", 1, "AD" };
                yield return new object[] { "en-UM", 0, "AD" };
                yield return new object[] { "en-UM", 1, "AD" };
                yield return new object[] { "en-US", 0, "AD" };
                yield return new object[] { "en-US", 1, "AD" };
                yield return new object[] { "en-VC", 0, "AD" };
                yield return new object[] { "en-VC", 1, "AD" };
                yield return new object[] { "en-VG", 0, "AD" };
                yield return new object[] { "en-VG", 1, "AD" };
                yield return new object[] { "en-VI", 0, "AD" };
                yield return new object[] { "en-VI", 1, "AD" };
                yield return new object[] { "en-VU", 0, "AD" };
                yield return new object[] { "en-VU", 1, "AD" };
                yield return new object[] { "en-WS", 0, "AD" };
                yield return new object[] { "en-WS", 1, "AD" };
                yield return new object[] { "en-ZA", 0, "AD" };
                yield return new object[] { "en-ZA", 1, "AD" };
                yield return new object[] { "en-ZM", 0, "AD" };
                yield return new object[] { "en-ZM", 1, "AD" };
                yield return new object[] { "en-ZW", 0, "AD" };
                yield return new object[] { "en-ZW", 1, "AD" };
                yield return new object[] { "en-US", 0, "AD" };
                yield return new object[] { "en-US", 1, "AD" };
                yield return new object[] { "es-ES", 0, "d. C." };
                yield return new object[] { "es-ES", 1, "d. C." };
                yield return new object[] { "es-419", 0, "d.C." };
                yield return new object[] { "es-419", 1, "d.C." };
                yield return new object[] { "es-MX", 0, "d.C." };
                yield return new object[] { "es-MX", 1, "d.C." };
                yield return new object[] { "et-EE", 0, "pKr" };
                yield return new object[] { "et-EE", 1, "pKr" };
                yield return new object[] { "fa-IR", 0, "ه.ش" }; // ه‍.ش.
                yield return new object[] { "fa-IR", 1, "ه.ش" };
                yield return new object[] { "fi-FI", 0, "jKr." };
                yield return new object[] { "fi-FI", 1, "jKr." };
                yield return new object[] { "fil-PH", 0, "AD" };
                yield return new object[] { "fil-PH", 1, "AD" };
                yield return new object[] { "fr-BE", 0, "ap. J.-C." };
                yield return new object[] { "fr-BE", 1, "ap. J.-C." };
                yield return new object[] { "fr-CA", 0, "ap. J.-C." };
                yield return new object[] { "fr-CA", 1, "ap. J.-C." };
                yield return new object[] { "fr-CH", 0, "ap. J.-C." };
                yield return new object[] { "fr-CH", 1, "ap. J.-C." };
                yield return new object[] { "fr-FR", 0, "ap. J.-C." };
                yield return new object[] { "fr-FR", 1, "ap. J.-C." };
                yield return new object[] { "gu-IN", 0, "ઈ.સ." };
                yield return new object[] { "gu-IN", 1, "ઈ.સ." };
                yield return new object[] { "he-IL", 0, "לספירה" };
                yield return new object[] { "he-IL", 1, "לספירה" };
                yield return new object[] { "hi-IN", 0, "ईस्वी" };
                yield return new object[] { "hi-IN", 1, "ईस्वी" };
                yield return new object[] { "hr-BA", 0, "po. Kr." };
                yield return new object[] { "hr-BA", 1, "po. Kr." };
                yield return new object[] { "hr-HR", 0, "po. Kr." };
                yield return new object[] { "hr-HR", 1, "po. Kr." };
                yield return new object[] { "hu-HU", 0, "i. sz." };
                yield return new object[] { "hu-HU", 1, "i. sz." };
                yield return new object[] { "id-ID", 0, "M" };
                yield return new object[] { "id-ID", 1, "M" };
                yield return new object[] { "it-CH", 0, "d.C." };
                yield return new object[] { "it-CH", 1, "d.C." };
                yield return new object[] { "it-IT", 0, "d.C." };
                yield return new object[] { "it-IT", 1, "d.C." };
                yield return new object[] { "ja-JP", 0, "西暦" };
                yield return new object[] { "ja-JP", 1, "西暦" };
                yield return new object[] { "kn-IN", 0, "ಕ್ರಿ.ಶ" };
                yield return new object[] { "kn-IN", 1, "ಕ್ರಿ.ಶ" };
                yield return new object[] { "ko-KR", 0, "AD" };
                yield return new object[] { "ko-KR", 1, "AD" };
                yield return new object[] { "lt-LT", 0, "po Kr." };
                yield return new object[] { "lt-LT", 1, "po Kr." };
                yield return new object[] { "lv-LV", 0, "m.ē." };
                yield return new object[] { "lv-LV", 1, "m.ē." };
                yield return new object[] { "ml-IN", 0, "എഡി" };
                yield return new object[] { "ml-IN", 1, "എഡി" };
                yield return new object[] { "mr-IN", 0, "इ. स." };
                yield return new object[] { "mr-IN", 1, "इ. स." };
                yield return new object[] { "ms-BN", 0, "TM" };
                yield return new object[] { "ms-BN", 1, "TM" };
                yield return new object[] { "ms-MY", 0, "TM" };
                yield return new object[] { "ms-MY", 1, "TM" };
                yield return new object[] { "ms-SG", 0, "TM" };
                yield return new object[] { "ms-SG", 1, "TM" };
                yield return new object[] { "nb-NO", 0, "e.Kr." };
                yield return new object[] { "nb-NO", 1, "e.Kr." };
                yield return new object[] { "no", 0, "e.Kr." };
                yield return new object[] { "no", 1, "e.Kr." };
                yield return new object[] { "no-NO", 0, "e.Kr." };
                yield return new object[] { "no-NO", 1, "e.Kr." };
                yield return new object[] { "nl-AW", 0, "n.Chr." };
                yield return new object[] { "nl-AW", 1, "n.Chr." };
                yield return new object[] { "nl-BE", 0, "n.Chr." };
                yield return new object[] { "nl-BE", 1, "n.Chr." };
                yield return new object[] { "nl-NL", 0, "n.Chr." };
                yield return new object[] { "nl-NL", 1, "n.Chr." };
                yield return new object[] { "pl-PL", 0, "n.e." };
                yield return new object[] { "pl-PL", 1, "n.e." };
                yield return new object[] { "pt-BR", 0, "d.C." };
                yield return new object[] { "pt-BR", 1, "d.C." };
                yield return new object[] { "pt-PT", 0, "d.C." };
                yield return new object[] { "pt-PT", 1, "d.C." };
                yield return new object[] { "ro-RO", 0, "d.Hr." };
                yield return new object[] { "ro-RO", 1, "d.Hr." };
                yield return new object[] { "ru-RU", 0, "н. э." };
                yield return new object[] { "ru-RU", 1, "н. э." };
                yield return new object[] { "sk-SK", 0, "po Kr." };
                yield return new object[] { "sk-SK", 1, "po Kr." };
                yield return new object[] { "sl-SI", 0, "po Kr." };
                yield return new object[] { "sl-SI", 1, "po Kr." };
                yield return new object[] { "sr-Cyrl-RS", 0, "н. е." };
                yield return new object[] { "sr-Cyrl-RS", 1, "н. е." };
                yield return new object[] { "sr-Latn-RS", 0, "n. e." };
                yield return new object[] { "sr-Latn-RS", 1, "n. e." };
                yield return new object[] { "sv-AX", 0, "e.Kr." };
                yield return new object[] { "sv-AX", 1, "e.Kr." };
                yield return new object[] { "sv-SE", 0, "e.Kr." };
                yield return new object[] { "sv-SE", 1, "e.Kr." };
                yield return new object[] { "sw-CD", 0, "BK" };
                yield return new object[] { "sw-CD", 1, "BK" };
                yield return new object[] { "sw-KE", 0, "BK" };
                yield return new object[] { "sw-KE", 1, "BK" };
                yield return new object[] { "sw-TZ", 0, "BK" };
                yield return new object[] { "sw-TZ", 1, "BK" };
                yield return new object[] { "sw-UG", 0, "BK" };
                yield return new object[] { "sw-UG", 1, "BK" };
                yield return new object[] { "ta-IN", 0, "கி.பி." };
                yield return new object[] { "ta-IN", 1, "கி.பி." };
                yield return new object[] { "ta-LK", 0, "கி.பி." };
                yield return new object[] { "ta-LK", 1, "கி.பி." };
                yield return new object[] { "ta-MY", 0, "கி.பி." };
                yield return new object[] { "ta-MY", 1, "கி.பி." };
                yield return new object[] { "ta-SG", 0, "கி.பி." };
                yield return new object[] { "ta-SG", 1, "கி.பி." };
                yield return new object[] { "te-IN", 0, "క్రీశ" };
                yield return new object[] { "te-IN", 1, "క్రీశ" };
                yield return new object[] { "th-TH", 0, "พ.ศ." };
                yield return new object[] { "th-TH", 1, "พ.ศ." };
                yield return new object[] { "tr-CY", 0, "MS" };
                yield return new object[] { "tr-CY", 1, "MS" };
                yield return new object[] { "tr-TR", 0, "MS" };
                yield return new object[] { "tr-TR", 1, "MS" };
                yield return new object[] { "uk-UA", 0, "н. е." };
                yield return new object[] { "uk-UA", 1, "н. е." };
                yield return new object[] { "vi-VN", 0, "CN" }; // sau CN
                yield return new object[] { "vi-VN", 1, "CN" }; // sau CN
                yield return new object[] { "zh-CN", 0, "公元" };
                yield return new object[] { "zh-CN", 1, "公元" };
                yield return new object[] { "zh-Hans-HK", 0, "公元" };
                yield return new object[] { "zh-Hans-HK", 1, "公元" };
                yield return new object[] { "zh-SG", 0, "公元" };
                yield return new object[] { "zh-SG", 1, "公元" };
                yield return new object[] { "zh-HK", 0, "公元" };
                yield return new object[] { "zh-HK", 1, "公元" };
                yield return new object[] { "zh-TW", 0, "西元" };
                yield return new object[] { "zh-TW", 1, "西元" };
            }
        }

        [Theory]
        [MemberData(nameof(GetEraName_TestData))]
        public void GetEraName_Invoke_ReturnsExpected(string cultureName, int era, string expected)
        {
            var format = cultureName == "invariant" ? DateTimeFormatInfo.InvariantInfo : new CultureInfo(cultureName).DateTimeFormat;
            var eraName = format.GetEraName(era);
            Assert.True(expected == eraName, $"Failed for culture: {cultureName}. Expected: {expected}, Actual: {eraName}");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(2)]
        public void GetEraName_InvalidEra_ThrowsArgumentOutOfRangeException(int era)
        {
            var format = new DateTimeFormatInfo();
            AssertExtensions.Throws<ArgumentOutOfRangeException>("era", () => format.GetEraName(era));
        }
    }
}