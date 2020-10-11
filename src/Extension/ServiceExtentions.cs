using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Skclusive.Extensions.DependencyInjection
{
    public static class DependencyInjectionExtentions
    {
        public static void TryAddTransientEnumerable<TService, TImplementation>(this IServiceCollection collection)
            where TService : class
            where TImplementation : class, TService
        {
            var serviceDescriptor = ServiceDescriptor.Transient<TService, TImplementation>();

            collection.TryAddEnumerable(serviceDescriptor);
        }

        public static void TryAddTransientEnumerable<TService, TImplementation>(this IServiceCollection collection, Func<IServiceProvider, TImplementation> implementationFactory)
            where TService : class
            where TImplementation : class, TService
        {
            var serviceDescriptor = ServiceDescriptor.Transient<TService, TImplementation>(implementationFactory);

            collection.TryAddEnumerable(serviceDescriptor);
        }

        public static void TryAddScopedEnumerable<TService, TImplementation>(this IServiceCollection collection)
            where TService : class
            where TImplementation : class, TService
        {
            var serviceDescriptor = ServiceDescriptor.Scoped<TService, TImplementation>();

            collection.TryAddEnumerable(serviceDescriptor);
        }

        public static void TryAddScopedEnumerable<TService, TImplementation>(this IServiceCollection collection, Func<IServiceProvider, TImplementation> implementationFactory)
            where TService : class
            where TImplementation : class, TService
        {
            var serviceDescriptor = ServiceDescriptor.Scoped<TService, TImplementation>(implementationFactory);

            collection.TryAddEnumerable(serviceDescriptor);
        }

        public static void TryAddSingletonEnumerable<TService, TImplementation>(this IServiceCollection collection)
            where TService : class
            where TImplementation : class, TService
        {
            var serviceDescriptor = ServiceDescriptor.Singleton<TService, TImplementation>();

            collection.TryAddEnumerable(serviceDescriptor);
        }

        public static void TryAddSingletonEnumerable<TService, TImplementation>(this IServiceCollection collection, Func<IServiceProvider, TImplementation> implementationFactory)
            where TService : class
            where TImplementation : class, TService
        {
            var serviceDescriptor = ServiceDescriptor.Singleton<TService, TImplementation>(implementationFactory);

            collection.TryAddEnumerable(serviceDescriptor);
        }
    }
}