﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace HashTagCreator
{
    [TestFixture]
    public class HashTagCreatorFixture
    {
        private const string FileName = "Fifa.CountryCodeHastags.txt";
        private FileInfo _outputFile;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            _outputFile = new FileInfo(Path.Combine(Environment.CurrentDirectory, FileName));
            if (_outputFile.Exists)
            {
                _outputFile.Delete();
            }
        }

        [Test]
        public void AllFifaMembers([ValueSource("FifaMembers")] string firstCode, [ValueSource("FifaMembers")] string secondCode)
        {
            PrintCode(firstCode, secondCode);
        }

        private void PrintCode(string firstCode, string secondCode)
        {
            string hashtag = string.Format(CultureInfo.InvariantCulture, "{0}{1}", firstCode, secondCode);
            Console.WriteLine(hashtag);

            using (var stream = new FileStream(_outputFile.FullName, FileMode.Append, FileAccess.Write))
            {
                using (var writer = new StreamWriter(stream))
                {
                    writer.WriteLine(hashtag);
                }
            }
        }

        private IEnumerable FifaMembers
        {
            get
            {
                return _fifaMembers.Values.ToList();
            }
        }


        #region Codes

        private readonly IDictionary<string, string> _fifaMembers = new Dictionary<string, string>
        {
            {"Afghanistan", "AFG"},
            {"Albania", "ALB"},
            {"Algeria", "ALG"},
            {"American Samoa", "ASA"},
            {"Andorra", "AND"},
            {"Angola", "ANG"},
            {"Anguilla", "AIA"},
            {"Antigua and Barbuda", "ATG"},
            {"Argentina", "ARG"},
            {"Armenia", "ARM"},
            {"Aruba", "ARU"},
            {"Australia", "AUS"},
            {"Austria", "AUT"},
            {"Azerbaijan", "AZE"},
            {"Bahamas", "BAH"},
            {"Bahrain", "BHR"},
            {"Bangladesh", "BAN"},
            {"Barbados", "BRB"},
            {"Belarus", "BLR"},
            {"Belgium", "BEL"},
            {"Belize", "BLZ"},
            {"Benin", "BEN"},
            {"Bermuda", "BER"},
            {"Bhutan", "BHU"},
            {"Bolivia", "BOL"},
            {"Bosnia and Herzegovina", "BIH"},
            {"Botswana", "BOT"},
            {"Brazil", "BRA"},
            {"British Virgin Islands", "VGB"},
            {"Brunei", "BRU"},
            {"Bulgaria", "BUL"},
            {"Burkina Faso", "BFA"},
            {"Burundi", "BDI"},
            {"Cambodia", "CAM"},
            {"Cameroon", "CMR"},
            {"Canada", "CAN"},
            {"Cape Verde", "CPV"},
            {"Cayman Islands", "CAY"},
            {"Central African Republic", "CTA"},
            {"Chad", "CHA"},
            {"Chile", "CHI"},
            {"China PR", "CHN"},
            {"Chinese Taipei", "TPE"},
            {"Colombia", "COL"},
            {"Comoros", "COM"},
            {"Congo", "CGO"},
            {"DR Congo", "COD"},
            {"Cook Islands", "COK"},
            {"Costa Rica", "CRC"},
            {"Côte d'Ivoire (Ivory Coast)", "CIV"},
            {"Croatia", "CRO"},
            {"Cuba", "CUB"},
            {"Curaçao", "CUW"},
            {"Cyprus", "CYP"},
            {"Czech Republic", "CZE"},
            {"Denmark", "DEN"},
            {"Djibouti", "DJI"},
            {"Dominica", "DMA"},
            {"Dominican Republic", "DOM"},
            {"Ecuador", "ECU"},
            {"Egypt", "EGY"},
            {"El Salvador", "SLV"},
            {"England", "ENG"},
            {"Equatorial Guinea", "EQG"},
            {"Eritrea", "ERI"},
            {"Estonia", "EST"},
            {"Ethiopia", "ETH"},
            {"Faroe Islands", "FRO"},
            {"Fiji", "FIJ"},
            {"Finland", "FIN"},
            {"France", "FRA"},
            {"Gabon", "GAB"},
            {"Gambia", "GAM"},
            {"Georgia", "GEO"},
            {"Germany", "GER"},
            {"Ghana", "GHA"},
            {"Greece", "GRE"},
            {"Grenada", "GRN"},
            {"Guam", "GUM"},
            {"Guatemala", "GUA"},
            {"Guinea", "GUI"},
            {"Guinea-Bissau", "GNB"},
            {"Guyana", "GUY"},
            {"Haiti", "HAI"},
            {"Honduras", "HON"},
            {"Hong Kong", "HKG"},
            {"Hungary", "HUN"},
            {"Iceland", "ISL"},
            {"India", "IND"},
            {"Indonesia", "IDN"},
            {"Iran", "IRN"},
            {"Iraq", "IRQ"},
            {"Israel", "ISR"},
            {"Italy", "ITA"},
            {"Jamaica", "JAM"},
            {"Japan", "JPN"},
            {"Jordan", "JOR"},
            {"Kazakhstan", "KAZ"},
            {"Kenya", "KEN"},
            {"North Korea", "PRK"},
            {"South Korea", "KOR"},
            {"Kuwait", "KUW"},
            {"Kyrgyzstan", "KGZ"},
            {"Laos", "LAO"},
            {"Latvia", "LVA"},
            {"Lebanon", "LIB"},
            {"Lesotho", "LES"},
            {"Liberia", "LBR"},
            {"Libya", "LBY"},
            {"Liechtenstein", "LIE"},
            {"Lithuania", "LTU"},
            {"Luxembourg", "LUX"},
            {"Macau", "MAC"},
            {"Macedonia", "MKD"},
            {"Madagascar", "MAD"},
            {"Malawi", "MWI"},
            {"Malaysia", "MAS"},
            {"Maldives", "MDV"},
            {"Mali", "MLI"},
            {"Malta", "MLT"},
            {"Mauritania", "MTN"},
            {"Mauritius", "MRI"},
            {"Mexico", "MEX"},
            {"Moldova", "MDA"},
            {"Mongolia", "MNG"},
            {"Montenegro", "MNE"},
            {"Montserrat", "MSR"},
            {"Morocco", "MAR"},
            {"Mozambique", "MOZ"},
            {"Myanmar", "MYA"},
            {"Namibia", "NAM"},
            {"Nepal", "NEP"},
            {"Netherlands", "NED"},
            {"New Caledonia", "NCL"},
            {"New Zealand", "NZL"},
            {"Nicaragua", "NCA"},
            {"Niger", "NIG"},
            {"Nigeria", "NGA"},
            {"Northern Ireland", "NIR"},
            {"Norway", "NOR"},
            {"Oman", "OMA"},
            {"Pakistan", "PAK"},
            {"Palestine", "PLE"},
            {"Panama", "PAN"},
            {"Papua New Guinea", "PNG"},
            {"Paraguay", "PAR"},
            {"Peru", "PER"},
            {"Philippines", "PHI"},
            {"Poland", "POL"},
            {"Portugal", "POR"},
            {"Puerto Rico", "PUR"},
            {"Qatar", "QAT"},
            {"Republic of Ireland", "IRL"},
            {"Romania", "ROU"},
            {"Russia", "RUS"},
            {"Rwanda", "RWA"},
            {"Saint Kitts and Nevis", "SKN"},
            {"Saint Lucia", "LCA"},
            {"Saint Vincent and the Grenadines", "VIN"},
            {"Samoa", "SAM"},
            {"San Marino", "SMR"},
            {"São Tomé and Príncipe", "STP"},
            {"Saudi Arabia", "KSA"},
            {"Scotland", "SCO"},
            {"Senegal", "SEN"},
            {"Serbia", "SRB"},
            {"Seychelles", "SEY"},
            {"Sierra Leone", "SLE"},
            {"Singapore", "SIN"},
            {"Slovakia", "SVK"},
            {"Slovenia", "SVN"},
            {"Solomon Islands", "SOL"},
            {"Somalia", "SOM"},
            {"South Africa", "RSA"},
            {"Spain", "ESP"},
            {"Sri Lanka", "SRI"},
            {"Sudan", "SDN"},
            {"South Sudan", "SSD"},
            {"Suriname", "SUR"},
            {"Swaziland", "SWZ"},
            {"Sweden", "SWE"},
            {"Switzerland", "SUI"},
            {"Syria", "SYR"},
            {"Tahiti", "TAH"},
            {"Tajikistan", "TJK"},
            {"Tanzania", "TAN"},
            {"Thailand", "THA"},
            {"Timor-Leste (East Timor)", "TLS"},
            {"Togo", "TOG"},
            {"Tonga", "TGA"},
            {"Trinidad and Tobago", "TRI"},
            {"Tunisia", "TUN"},
            {"Turkey", "TUR"},
            {"Turkmenistan", "TKM"},
            {"Turks and Caicos Islands", "TCA"},
            {"Uganda", "UGA"},
            {"Ukraine", "UKR"},
            {"United Arab Emirates", "UAE"},
            {"United States", "USA"},
            {"Uruguay", "URU"},
            {"U.S. Virgin Islands", "VIR"},
            {"Uzbekistan", "UZB"},
            {"Vanuatu", "VAN"},
            {"Venezuela", "VEN"},
            {"Vietnam", "VIE"},
            {"Wales", "WAL"},
            {"Yemen", "YEM"},
            {"Zambia", "ZAM"},
            {"Zimbabwe", "ZIM"}
        };

        private IDictionary<string, string> _nonMembers = new Dictionary<string, string>
        {
            {"Bonaire", "BOE"},
            {"French Guiana", "GYF"},
            {"Gibraltar", "GIB"},
            {"Guadeloupe", "GPE"},
            {"Martinique", "MTQ"},
            {"Réunion", "REU"},
            {"Sint Maarten", "SXM"},
            {"Tuvalu", "TUV"},
            {"Zanzibar", "ZAN"},
            {"Kosovo", "KOS"}
        };

        private IDictionary<string, string> _obsolete = new Dictionary<string, string>
        {
            {"Aden", "ADE"},
            {"British Guiana", "BGU"},
            {"British Honduras", "BHO"},
            {"British India", "BIN"},
            {"Bohemia", "BOH"},
            {"Burma", "BUR"},
            {"Central African Republic", "CAF"},
            {"Ceylon", "CEY"},
            {"Commonwealth of Independent States", "CIS"},
            {"Congo-Kinshasa", "CKN"},
            {"Congo-Brazzaville", "COB"},
            {"Czechoslovakia", "TCH"},
            {"Dahomey", "DAH"},
            {"Dutch East Indies", "DEI"},
            {"East Germany", "GDR"},
            {"Gold Coast", "GOC"},
            {"Ireland", "EIR"},
            {"Netherlands Antilles", "ANT"},
            {"Netherlands", "HOL"},
            {"New Hebrides", "HEB"},
            {"North Borneo", "NBO"},
            {"North Vietnam", "VNO"},
            {"North Yemen", "NYE"},
            {"Northern Rhodesia", "NRH"},
            {"Palestine, British Mandate", "PAL"},
            {"Romania", "ROM"},
            {"Rhodesia", "RHO"},
            {"Saar", "SAA"},
            {"Serbia and Montenegro", "SCG"},
            {"Siam", "SIA"},
            {"Southern Rhodesia", "SRH"},
            {"South Vietnam", "VSO"},
            {"South Yemen", "SYE"},
            {"Soviet Union", "URS"},
            {"Sudan", "SUD"},
            {"Suriname", "NGY"},
            {"Tanganyika", "TAA"},
            {"Taiwan", "TAI"},
            {"United Arab Republic", "UAR"},
            {"Upper Volta", "UPV"},
            {"West Germany", "FRG"},
            {"Western Samoa", "WSM"},
            {"Yugoslavia", "YUG"},
            {"Zaire", "ZAI"}
        };

        private IDictionary<string, string> _irregular = new Dictionary<string, string>
        {
            {"F.S. Micronesia", "FSM"},
            {"Kiribati", "KIR"},
            {"Niue", "NIU"},
            {"Northern Mariana Islands", "NMI"},
            {"Palau", "PLW"},
            {"Saint-Martin", "SMT"}
        };

        #endregion
    }
}
