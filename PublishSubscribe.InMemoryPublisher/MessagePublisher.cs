using System;
using System.Threading.Tasks;
using PublishSubscribe.Core;

namespace PublishSubscribe.InMemoryPublisher
{
    public class MessagePublisher : IMessagePublisher
    {
        public async Task Publish<TMessage>(TMessage message) where TMessage : class, new()
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Received message {typeof(TMessage)}");
            });
        }
    }
}
