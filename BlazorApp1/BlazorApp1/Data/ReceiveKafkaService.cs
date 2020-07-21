using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APLKafka.kafka;
using Confluent.Kafka;

namespace BlazorApp1.Data
{
    public class ReceiveKafkaService
    {
        private KafkaConsumer _kafkaConsumer;
        private ConsumeResult<string, string> consumeResult;
        public Task<ReceiveKafkaModel[]> GetKafkaMsg()
        {
            consumeResult = _kafkaConsumer.ReceiveMessageAsync();
            return Task.FromResult(Enumerable.Range(1, 5).Select(Index => new ReceiveKafkaModel
            {
                Date = DateTime.Now,
                Topic = consumeResult.Topic,
                Content = consumeResult.Message.Value

            }).ToArray());

        }
    }
}
