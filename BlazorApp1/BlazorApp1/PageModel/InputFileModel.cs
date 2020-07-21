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
    public class InputFileModel : ComponentBase, IDisposable
    {
        private IJSRuntime JSRuntime { get; }
        [Parameter(CaptureUnmatchedValues = true)] public Dictionary<string, object> UnmatchedParameters { get; set; }
        [Parameter] public EventCallback<IFileListEntry[]> OnChange { get; set; }
        [Parameter] public int MaxMessageSize { get; set; } = 20 * 1024; // TODO: Use SignalR default
        [Parameter] public int MaxBufferSize { get; set; } = 1024 * 1024;

        public ElementReference inputFileElement;
        IDisposable thisReference;

        [JSInvokable]
        public Task NotifyChange(FileListEntryImpl[] files)
        {
            foreach (var file in files)
            {
                // So that method invocations on the file can be dispatched back here
                file.Owner = (InputFile)(object)this;
            }

            return OnChange.InvokeAsync(files);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                thisReference = DotNetObjectReference.Create(this);
                await JSRuntime.InvokeAsync<object>("BlazorInputFile.init", inputFileElement, thisReference);
            }
        }

        internal Stream OpenFileStream(FileListEntryImpl file)
        {
            return SharedMemoryFileListEntryStream.IsSupported(JSRuntime)
                ? (Stream)new SharedMemoryFileListEntryStream(JSRuntime, inputFileElement, file)
                : new RemoteFileListEntryStream(JSRuntime, inputFileElement, file, MaxMessageSize, MaxBufferSize);
        }

        internal async Task<FileListEntryImpl> ConvertToImageFileAsync(FileListEntryImpl file, string format, int maxWidth, int maxHeight)
        {
            var imageFile = await JSRuntime.InvokeAsync<FileListEntryImpl>("BlazorInputFile.toImageFile", inputFileElement, file.Id, format, maxWidth, maxHeight);

            // So that method invocations on the file can be dispatched back here
            imageFile.Owner = (InputFile)(object)this;

            return imageFile;
        }

        void IDisposable.Dispose()
        {
            thisReference?.Dispose();
        }

    }
}
