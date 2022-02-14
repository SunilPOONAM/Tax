using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

namespace TaxService.Models
{
    public class LanguageModel
    {
        public static List<Languages> AvailableLanguages = new List<Languages> {
            new Languages {
                LanguageFullName = "English", LanguageCultureName = "en"
            },
            new Languages {
                LanguageFullName = "Portuguese", LanguageCultureName = "pt"
            },
            new Languages {
                LanguageFullName = "Polish", LanguageCultureName = "pl-PL"
            },
            new Languages {
                LanguageFullName = "Creole-French", LanguageCultureName = "fr"
            },
            new Languages {
                LanguageFullName = "Tagalog", LanguageCultureName = "en-PH"
            },
            new Languages {
                LanguageFullName = "Chinese Simplified Version", LanguageCultureName = "zh-CHS"
            },
            new Languages {
                LanguageFullName = "Chinese Traditional Version", LanguageCultureName = "zh-CHT"
            },
            new Languages {
                LanguageFullName = "Spanish", LanguageCultureName = "es"
            },
            new Languages {
                LanguageFullName = "Korean", LanguageCultureName = "ko"
            },
            new Languages {
                LanguageFullName = "Vietnamese", LanguageCultureName = "vi"
            },
            new Languages {
                LanguageFullName = "Arabic", LanguageCultureName = "ar"
            },
        };
        public static bool IsLanguageAvailable(string lang)
        {
            return AvailableLanguages.Where(a => a.LanguageCultureName.Equals(lang)).FirstOrDefault() != null ? true : false;
        }
        public static string GetDefaultLanguage()
        {
            return AvailableLanguages[0].LanguageCultureName;
        }
        public void SetLanguage(string lang)
        {
            try
            {
                if (!IsLanguageAvailable(lang)) lang = GetDefaultLanguage();
                var cultureInfo = new CultureInfo(lang);
                Thread.CurrentThread.CurrentUICulture = cultureInfo;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureInfo.Name);
                HttpCookie langCookie = new HttpCookie("culture", lang);
                langCookie.Expires = DateTime.Now.AddYears(1);
                HttpContext.Current.Response.Cookies.Add(langCookie);
                HttpContext.Current.Session["langId"] = lang;
            }
            catch (Exception) { }
        }
    }
    public class Languages
    {
        public string LanguageFullName
        {
            get;
            set;
        }
        public string LanguageCultureName
        {
            get;
            set;
        }
    }
}