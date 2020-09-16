using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using DeviceService.Entity;
using SimulatorTool.PagesModel;
using BlazorApp1.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace BlazorApp1.PageModel
{
    public class MultiMovePageModel : MyComponentBase
    {
        public List<RegisterModel> Clients { get; set; }
        public string SelectClient { get; set; }
        private bool PosAttribute { get; set; }   
        public Action RefreshHandler { get; set; }
        public int Index { get; set; } = 0;
        public DragItem Item { get; set; }

        public string _highlightDropTargetStyle = null;
        [Inject()]
        public DragDropHelper DragDropHelper { get; set; }
        [Inject()]
        public JsHelper JsHelper { get; set; }
        public List<string> Positions { get; set; }

        public MultiMovePageModel()
        {
            Item = new DragItem();
        }
        public async void AttributeChanged(string key, ChangeEventArgs args)
        {
            //if (string.IsNullOrEmpty(SelectClient))
            //{
            //    await Alert("选择一个客户端");
            //    return;
            //}
            try
            {
                await Task.Run(() => AttributeValueChanged(key, args.Value));
            }
            catch (Exception ex)
            {
                await Alert(ex.Message);
            }
        }
        private async void AttributeValueChanged(string key, object value)
        {
            //pos勾选，执行顺序中显示pos号
            try
            {
                PosAttribute = bool.Parse(value.ToString());
                switch (PosAttribute)
                {
                    case true:
                        Positions.Add(key);
                        await JSRuntime.InvokeAsync<object>("AddPosList", TimeSpan.FromHours(8), key);
                        break;
                    case false:
                        Positions.Remove(key);
                        await JSRuntime.InvokeAsync<object>("RemovePosList", TimeSpan.FromHours(8), key);
                        break;
                }
            }
            catch (Exception ex)
            {
                await Alert(ex.Message);
            }

        }

        public void OnItemDragStart(DragEventArgs e, string PosName)
        {
            //Item = dragItem;
            Item.Text = PosName;
            Item.Index = Index;
            Index++;
        }

        public void OnContainerDragEnter(DragEventArgs e)
        {
            _highlightDropTargetStyle = "border:5px dashed salmon !important";
        }

        public void OnContainerDragLeave(DragEventArgs e)
        {
            _highlightDropTargetStyle = "border:5px dashed salmon !important";
        }

        public async void OnContainerDrop(DragEventArgs e, int newIndex)
        {
            try
            {
                _highlightDropTargetStyle = null;
                //Item.Index = newIndex;
                RefreshHandler = () => StateHasChanged();
                //执行js代码
                //JsHelper.ExecuteScript("OnDrop", null);
                await JSRuntime.InvokeAsync<object>("OnDrop", TimeSpan.FromHours(8));
            }
            catch (Exception ex)
            {
                await Alert(ex.Message);
            }
        }  
        //public void PosClick(string args)
        //{

        //}
    }
}
