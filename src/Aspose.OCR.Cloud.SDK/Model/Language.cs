/*
 * Aspose OCR Cloud 5.0 API
 *
 * Aspose OCR Cloud 5.0 API
 *


 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Aspose.OCR.Cloud.SDK.Client.OpenAPIDateConverter;

namespace Aspose.OCR.Cloud.SDK.Model
{
    /// <summary>
    /// Recognition Language
    /// </summary>
    /// <value>Recognition Language</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Language
    {
        /// <summary>
        /// Enum English for value: English
        /// </summary>
        [EnumMember(Value = "English")]
        English = 1,

        /// <summary>
        /// Enum German for value: German
        /// </summary>
        [EnumMember(Value = "German")]
        German = 2,

        /// <summary>
        /// Enum French for value: French
        /// </summary>
        [EnumMember(Value = "French")]
        French = 3,

        /// <summary>
        /// Enum Italian for value: Italian
        /// </summary>
        [EnumMember(Value = "Italian")]
        Italian = 4,

        /// <summary>
        /// Enum Spanish for value: Spanish
        /// </summary>
        [EnumMember(Value = "Spanish")]
        Spanish = 5,

        /// <summary>
        /// Enum Portuguese for value: Portuguese
        /// </summary>
        [EnumMember(Value = "Portuguese")]
        Portuguese = 6,

        /// <summary>
        /// Enum Polish for value: Polish
        /// </summary>
        [EnumMember(Value = "Polish")]
        Polish = 7,

        /// <summary>
        /// Enum Slovene for value: Slovene
        /// </summary>
        [EnumMember(Value = "Slovene")]
        Slovene = 8,

        /// <summary>
        /// Enum Slovak for value: Slovak
        /// </summary>
        [EnumMember(Value = "Slovak")]
        Slovak = 9,

        /// <summary>
        /// Enum Netherlands for value: Netherlands
        /// </summary>
        [EnumMember(Value = "Netherlands")]
        Netherlands = 10,

        /// <summary>
        /// Enum Lithuanian for value: Lithuanian
        /// </summary>
        [EnumMember(Value = "Lithuanian")]
        Lithuanian = 11,

        /// <summary>
        /// Enum Latvian for value: Latvian
        /// </summary>
        [EnumMember(Value = "Latvian")]
        Latvian = 12,

        /// <summary>
        /// Enum Danish for value: Danish
        /// </summary>
        [EnumMember(Value = "Danish")]
        Danish = 13,

        /// <summary>
        /// Enum Norwegian for value: Norwegian
        /// </summary>
        [EnumMember(Value = "Norwegian")]
        Norwegian = 14,

        /// <summary>
        /// Enum Finnish for value: Finnish
        /// </summary>
        [EnumMember(Value = "Finnish")]
        Finnish = 15,

        /// <summary>
        /// Enum Serbian for value: Serbian
        /// </summary>
        [EnumMember(Value = "Serbian")]
        Serbian = 16,

        /// <summary>
        /// Enum Croatian for value: Croatian
        /// </summary>
        [EnumMember(Value = "Croatian")]
        Croatian = 17,

        /// <summary>
        /// Enum Czech for value: Czech
        /// </summary>
        [EnumMember(Value = "Czech")]
        Czech = 18,

        /// <summary>
        /// Enum Swedish for value: Swedish
        /// </summary>
        [EnumMember(Value = "Swedish")]
        Swedish = 19,

        /// <summary>
        /// Enum Estonian for value: Estonian
        /// </summary>
        [EnumMember(Value = "Estonian")]
        Estonian = 20,

        /// <summary>
        /// Enum Romanian for value: Romanian
        /// </summary>
        [EnumMember(Value = "Romanian")]
        Romanian = 21,

        /// <summary>
        /// Enum Chinese for value: Chinese
        /// </summary>
        [EnumMember(Value = "Chinese")]
        Chinese = 22,

        /// <summary>
        /// Enum Russian for value: Russian
        /// </summary>
        [EnumMember(Value = "Russian")]
        Russian = 23,

        /// <summary>
        /// Enum Arabic for value: Arabic
        /// </summary>
        [EnumMember(Value = "Arabic")]
        Arabic = 24,

        /// <summary>
        /// Enum Hindi for value: Hindi
        /// </summary>
        [EnumMember(Value = "Hindi")]
        Hindi = 25,

        /// <summary>
        /// Enum Ukrainan for value: Ukrainan
        /// </summary>
        [EnumMember(Value = "Ukrainan")]
        Ukrainan = 26,

        /// <summary>
        /// Enum Bengali for value: Bengali
        /// </summary>
        [EnumMember(Value = "Bengali")]
        Bengali = 27,

        /// <summary>
        /// Enum Tibetan for value: Tibetan
        /// </summary>
        [EnumMember(Value = "Tibetan")]
        Tibetan = 28,

        /// <summary>
        /// Enum Thai for value: Thai
        /// </summary>
        [EnumMember(Value = "Thai")]
        Thai = 29,

        /// <summary>
        /// Enum Urdu for value: Urdu
        /// </summary>
        [EnumMember(Value = "Urdu")]
        Urdu = 30,

        /// <summary>
        /// Enum Turkish for value: Turkish
        /// </summary>
        [EnumMember(Value = "Turkish")]
        Turkish = 31,

        /// <summary>
        /// Enum Korean for value: Korean
        /// </summary>
        [EnumMember(Value = "Korean")]
        Korean = 32,

        /// <summary>
        /// Enum Indonesian for value: Indonesian
        /// </summary>
        [EnumMember(Value = "Indonesian")]
        Indonesian = 33,

        /// <summary>
        /// Enum Hebrew for value: Hebrew
        /// </summary>
        [EnumMember(Value = "Hebrew")]
        Hebrew = 34,

        /// <summary>
        /// Enum Javanese for value: Javanese
        /// </summary>
        [EnumMember(Value = "Javanese")]
        Javanese = 35,

        /// <summary>
        /// Enum Greek for value: Greek
        /// </summary>
        [EnumMember(Value = "Greek")]
        Greek = 36,

        /// <summary>
        /// Enum Japanese for value: Japanese
        /// </summary>
        [EnumMember(Value = "Japanese")]
        Japanese = 37,

        /// <summary>
        /// Enum Persian for value: Persian
        /// </summary>
        [EnumMember(Value = "Persian")]
        Persian = 38,

        /// <summary>
        /// Enum Albanian for value: Albanian
        /// </summary>
        [EnumMember(Value = "Albanian")]
        Albanian = 39,

        /// <summary>
        /// Enum Latin for value: Latin
        /// </summary>
        [EnumMember(Value = "Latin")]
        Latin = 40,

        /// <summary>
        /// Enum Vietnamese for value: Vietnamese
        /// </summary>
        [EnumMember(Value = "Vietnamese")]
        Vietnamese = 41,

        /// <summary>
        /// Enum Uzbek for value: Uzbek
        /// </summary>
        [EnumMember(Value = "Uzbek")]
        Uzbek = 42,

        /// <summary>
        /// Enum Georgian for value: Georgian
        /// </summary>
        [EnumMember(Value = "Georgian")]
        Georgian = 43,

        /// <summary>
        /// Enum Bulgarian for value: Bulgarian
        /// </summary>
        [EnumMember(Value = "Bulgarian")]
        Bulgarian = 44,

        /// <summary>
        /// Enum Azerbaijani for value: Azerbaijani
        /// </summary>
        [EnumMember(Value = "Azerbaijani")]
        Azerbaijani = 45,

        /// <summary>
        /// Enum Kazah for value: Kazah
        /// </summary>
        [EnumMember(Value = "Kazah")]
        Kazah = 46,

        /// <summary>
        /// Enum Macedonian for value: Macedonian
        /// </summary>
        [EnumMember(Value = "Macedonian")]
        Macedonian = 47,

        /// <summary>
        /// Enum Belorussian for value: Belorussian
        /// </summary>
        [EnumMember(Value = "Belorussian")]
        Belorussian = 48,

        /// <summary>
        /// Enum HWTEng for value: HWT_eng
        /// </summary>
        [EnumMember(Value = "HWT_eng")]
        HWTEng = 49

    }

}
