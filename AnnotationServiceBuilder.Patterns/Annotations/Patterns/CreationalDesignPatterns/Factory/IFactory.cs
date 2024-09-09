﻿namespace AnnotationServiceBuilder.Patterns.Annotations.Patterns.CreationalDesignPatterns.Factory
{
    /// <summary>
    /// Defines a factory interface for creating instances of type <typeparamref name="T"/>.
    /// This interface is used to implement the Factory Design Pattern, where the factory
    /// is responsible for creating objects of a specified type.
    /// </summary>
    /// <typeparam name="T">The type of object that the factory creates.</typeparam>
    public interface IFactory<T>
    {
        /// <summary>
        /// Creates an instance of type <typeparamref name="T"/>.
        /// This method should be implemented to return a new object of type <typeparamref name="T"/>.
        /// </summary>
        /// <returns>A new instance of type <typeparamref name="T"/>.</returns>
        T Create();
    }
}
