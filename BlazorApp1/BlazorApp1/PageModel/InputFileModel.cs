using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APLActions;
using APLKafka.kafka;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BlazorApp1.Data;
using Microsoft.JSInterop;
using BlazorApp1.Pages;
using System.IO;
//implements IDisposable
//using IJSRuntime;

namespace BlazorApp1.PageModel
{
    public class InputFileModel : ComponentBase
    {
        [Inject()]
        private IJSRuntime JSRuntime { get; set; }
        [Parameter(CaptureUnmatchedValues = true)] public Dictionary<string, object> UnmatchedParameters { get; set; }
        //[Parameter] public EventCallback<IFileListEntry[]> OnChange { get; set; }
        [Parameter] public int MaxMessageSize { get; set; } = 20 * 1024; // TODO: Use SignalR default
        [Parameter] public int MaxBufferSize { get; set; } = 1024 * 1024;

        public ElementReference inputFileElement;
        IDisposable thisReference;

              
        public async void Upload()
        {
            string result = string.Empty;
            await Task.Run(() => result = JSRuntime.InvokeAsync<string>("getFileText", "#inputfile").Result);
            foreach (char comm in result)
            {

            }
        }

    }
}
