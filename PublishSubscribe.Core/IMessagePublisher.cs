using System.Threading.Tasks;

namespace PublishSubscribe.Core
{
    public interface IMessagePublisher
    {
        Task Publish<TMessage>(TMessage message) where TMessage : class, new();
    }
}
