using Microsoft.Extensions.DependencyInjection;

namespace PublishSubscribe.Core
{
    public static class ServiceBusRegistration
    {
        public static IServiceCollection UseMessagePublisher<TMessagePublisher>(this IServiceCollection services) where TMessagePublisher : class, IMessagePublisher
        {
            services.Add(ServiceDescriptor.Singleton<IMessagePublisher, TMessagePublisher>());

            return services;
        }
    }
}