using Microsoft.Extensions.DependencyInjection;
using System;

namespace AnnotationServiceBuilder.Patterns.Annotations.Patterns.CreationalDesignPatterns.Factory
{
    /// <summary>
    /// Attribute used to mark a class as a factory that follows the Factory Design Pattern.
    /// This attribute facilitates registration of the factory in the dependency injection (DI) container
    /// with a specified service lifetime.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class FactoryPatternAttribute : Attribute
    {
        /// <summary>
        /// Gets the type of the factory interface that the class implements.
        /// The interface must have a method that returns an object.
        /// </summary>
        public Type ExpectedFactoryType { get; }

        /// <summary>
        /// Gets the lifetime of the service when registered in the dependency injection container.
        /// Defaults to <see cref="ServiceLifetime.Singleton"/> if not specified.
        /// </summary>
        public ServiceLifetime Lifetime { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FactoryPatternAttribute"/> class.
        /// This constructor allows specifying the factory interface and optionally the lifetime for service registration.
        /// </summary>
        /// <param name="expectedFactoryType">The type of the factory interface that the class implements.</param>
        /// <param name="lifetime">The lifetime of the service when registered in the DI container. Defaults to <see cref="ServiceLifetime.Singleton"/>.</param>
        public FactoryPatternAttribute(Type expectedFactoryType, ServiceLifetime lifetime = ServiceLifetime.Singleton)
        {
            ExpectedFactoryType = expectedFactoryType;
            Lifetime = lifetime;
        }
    }
}
