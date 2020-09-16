using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulatorTool.PagesModel
{
    public class MyComponentBase : ComponentBase
    {
        [Inject()]
        public IJSRuntime JSRuntime { get; set; }


        public MyComponentBase()
        {
        }


        protected void Set<T>(ref T field, T newValue = default)
        {
            field = newValue;
            StateHasChanged();
        }

        #region  弹框
        public ValueTask<object> Alert(string msg)
        {
            return JSRuntime.InvokeAsync<Object>("window.alert", TimeSpan.FromHours(8), msg);
        }

        public ValueTask<string> Prompt(string notice)
        {
            return JSRuntime.InvokeAsync<string>("window.prompt", TimeSpan.FromHours(8), notice);
        }

        public ValueTask<bool> Confirm(string msg)
        {
            return JSRuntime.InvokeAsync<bool>("window.confirm", TimeSpan.FromHours(8), msg);
        }

        public ValueTask<string> ShowDialog(string msg)
        {
            return JSRuntime.InvokeAsync<string>("openDialogWin", TimeSpan.FromHours(8), msg);
        }

        public ValueTask Reload()
        {
            return JSRuntime.InvokeVoidAsync("window.location.reload", TimeSpan.FromHours(8));
        }

        public string BindingLanguage(BlazorApp1.Language.LanguageKey languageKey)
        {
            return BlazorApp1.Language.Language.GetTxtById(languageKey);
        }

        #endregion
    }
}
