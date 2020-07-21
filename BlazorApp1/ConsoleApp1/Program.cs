using System;
using System.IO;
using System.Threading.Tasks;
using APLActions;
using BlazorApp1.Data;
using BlazorApp1.Data.kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static Raven.Client.Constants;

namespace ConsoleApp1
{
    class Program
    {
        private ILogger<KafkaProducer> logger;
        private IConfiguration configuration;
        private KafkaProducer _producer;
        private bool result;
        public void ScanHotel()
        {
            try
            {
                result = _producer.SendMessageAsync("125", "task_apl_yzq", "test");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
            }
        }

        static void Main(string[] args)
        {
            string msg = @"
                {{
                    ""message_id"": ""UUID"",
                    ""message_type"": ""device_command"",
                    ""message_group"": ""{0}"",
                    ""message_content"": {{
                        ""module_id"": ""7"",
                        ""device_type"": ""Hotel"",
                        ""device_id"": ""{1}"",
                        ""command_id"": ""{2}"",
                        ""command"": ""{3}"",
                        ""parameters"": {{
                            ""rack_idxs"": []
                        }}
                    }}
                }}";
            string comm = String.Format(msg, "topic", "c3", "commId", "scanhotel");
            string aa = @"lkahsg""khsagh""{0}sags
                {{kjahg{1}
                ""{2}""
                {3}}}";
            //string comm = String.Format(aa, "ss", "bb", "111", "222");
            var command = JsonConvert.DeserializeObject(comm);
            Console.WriteLine(command);
            
            Console.WriteLine(command.GetType());

            //    Program p = new Program();

            //    var kafkasetting = p.ReadJsonFile("appsettings.json");

            //    p._producer = new KafkaProducer(p.logger, kafkasetting);
            //    p.ScanHotel();
            //}

            //private KafkaSetting ReadJsonFile(string path)
            //{
            //    using (var file = File.OpenText(path))
            //    {
            //        var serializer = new JsonSerializer();
            //        return serializer.Deserialize<KafkaSetting>(new JsonTextReader(file));
            //    }
        }

    }
    
}
