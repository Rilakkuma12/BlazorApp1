using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Language
{
    public static class Language
    {
        public static string Current = System.Threading.Thread.CurrentThread.CurrentCulture.Name;

        public static void SetLanguage(string language)
        {
            Current = language;
        }

        /// <summary>
        /// 转换中英文（动态绑定到UI，切换语言）
        /// </summary>
        /// <param name="txtId"></param>
        /// <returns></returns>
        public static string GetTxtById(LanguageKey txtId)
        {
            string text = txtId.ToString();
            switch (Current)
            {
                case "zh-CN":
                    if (Chinese.Zh_Resource.ContainsKey(txtId))
                        text = Chinese.Zh_Resource[txtId];
                    break;
                default:
                    if (English.En_Resource.ContainsKey(txtId))
                        text = English.En_Resource[txtId];
                    break;
            }
            return text;
        }
    }
    }

