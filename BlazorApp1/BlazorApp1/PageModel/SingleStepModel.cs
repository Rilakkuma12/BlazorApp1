using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APLActions;
using APLKafka.kafka;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BlazorApp1.PageModel
{
    public class SingleStepModel : ComponentBase
    {
        private AplQuery aplQuery { get; set; }
        private AplScan aplScan { get; set; }
        private KafkaConsumer kafkaConsumer { get; set; }
        private string result;
        private string device = "373ab63a143543a0a490a00346b93bc5";
        private string pos = "POS3";
        protected string Click()
        {
            result = aplQuery.TableQuery(device, pos);
            JObject jo = (JObject)JsonConvert.DeserializeObject(result);
            foreach (JObject item in jo["Content"][device])
            {
                if (item["Position"].ToString() == pos)
                {

                    return item["BarCode"].ToString();
                }
                else
                {
                    return null;
                }

            }
            return "";
        }
        protected void Scan()
        {
            aplScan.ScanHotel();
        }
        protected void KafkaConsume()
        {
            kafkaConsumer.ReceiveMessageAsync();

        }
    }
}
