using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BlazorApp1.PageModel
{
    public class SendKafkaModel : ComponentBase
    {
        [Inject()]
        private KafkaProducer kafkaProducer { get; set; }

        [Inject()]
        private IJSRuntime JsRuntime { get; set; }
        /* 1.获取消息框的内容
        2.选择对应的主题
        3.发送到kafka服务器 */
        public string message;
        public string topic = "task_lims_yzq";
        public List<string> topics = new List<string>();
        private int taskid = 0;
        private bool task_result;

        protected override async Task OnInitializedAsync()
        {
            topics = kafkaProducer.GetTopics();
            
        }

        protected async void SendMessage()
        {
            await JsRuntime.InvokeAsync<object>("window.alert", "yangzhiqiong");
            //task_result = kafkaProducer.SendMessageAsync(taskid.ToString(), topic, JsonConvert.SerializeObject(message));
            //taskid++;
        }
    }
}
