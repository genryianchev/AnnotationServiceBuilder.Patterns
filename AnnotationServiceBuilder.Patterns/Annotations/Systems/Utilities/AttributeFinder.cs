using AnnotationServiceBuilder.Annotations.Patterns.CreationalDesignPatterns.Factory;

namespace AnnotationServiceBuilder.Annotations.Systems.Utilities
{
    public static class AttributeFinder
    {
        /// <summary>
        /// A predefined set of attribute types that are used for filtering types within assemblies.
        /// These attributes are commonly used to mark services or components for Dependency Injection (DI) 
        /// or other pattern-related functionalities.
        /// </summary>
        public static readonly HashSet<Type> attributeTypes = new HashSet<Type>
        {
            /// <summary>
            /// Attribute used to implement the Factory design pattern in DI containers.
            /// </summary>
            typeof(FactoryPatternAttribute)
        };
    }
}
