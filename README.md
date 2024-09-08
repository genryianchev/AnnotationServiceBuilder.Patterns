
# ![AnnotationServiceBuilder Icon](https://github.com/genryianchev/AnnotationServiceBuilder/raw/main/AnnotationServiceBuilder/icon.png) AnnotationServiceBuilder.Patterns

**AnnotationServiceBuilder.Patterns** is a library that provides support for implementing common design patterns in .NET applications using custom annotations. This library is part of the [AnnotationServiceBuilder](https://github.com/genryianchev/AnnotationServiceBuilder) ecosystem and focuses on facilitating the use of design patterns such as Factory via annotation-based service registration.

## Key Features

- **Factory Pattern**: Easily register factories with the DI container using `[FactoryPattern]`, allowing for flexible object creation and dependency management.
- Simplifies codebase by removing the need for manual service registration.
- Integrates seamlessly with .NET dependency injection.

## Installation

To install **AnnotationServiceBuilder.Patterns**, use the following command:

```bash
dotnet add package AnnotationServiceBuilder.Patterns
```

Alternatively, you can install it through the NuGet Package Manager in Visual Studio.

## Usage

### Factory Pattern

The `FactoryPatternAttribute` allows for the annotation-based registration of factory classes. These classes should implement a factory interface, typically following the Factory Design Pattern, to create instances of specific types.

```csharp
[FactoryPattern(typeof(IMyFactory), ServiceLifetime.Scoped)]
public class MyFactory : IMyFactory
{
    public MyObject Create()
    {
        return new MyObject();
    }
}
```

- **`IMyFactory`**: The interface that the factory implements.
- **`ServiceLifetime.Scoped`**: The lifetime of the factory in the DI container (can also be `Singleton` or `Transient`).

### Registering Factory Pattern Services

Before registering, initialize the pattern registrar:

```csharp
AnnotationPatternRegistrar.Initialize(Assembly.GetExecutingAssembly());
```

Once initialized, you can register the factory pattern services into the dependency injection container:

```csharp
AnnotationPatternRegistrar.AddFactoryPatternServices(builder.Services);
```

This will automatically scan your assembly for classes marked with the `[FactoryPattern]` attribute and register them in the DI container.

### Example: Registering Factory Services in `Program.cs`

In a minimal API setup (for .NET 6 and higher), here’s how you can initialize and register factory services:

```csharp
var builder = WebApplication.CreateBuilder(args);

// Initialize the assembly with all patterns
AnnotationPatternRegistrar.Initialize(Assembly.GetExecutingAssembly());

// Register all factory pattern services
AnnotationPatternRegistrar.AddFactoryPatternServices(builder.Services);

var app = builder.Build();

// Add your middlewares and endpoints here

app.Run();
```

This will ensure that all factory services marked with `[FactoryPattern]` are properly registered in the DI container.

### Example: Registering Factory Services in `Startup.cs`

If you are using a traditional `Startup.cs` class (for example, in an ASP.NET Core MVC app), here's how to register factory services:

```csharp
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Initialize the assembly with all patterns
        AnnotationPatternRegistrar.Initialize(Assembly.GetExecutingAssembly());

        // Register all factory pattern services
        services.AddFactoryPatternServices();
    }
}
```

## Contributing

If you'd like to contribute to **AnnotationServiceBuilder.Patterns**, feel free to submit a pull request or open an issue on the [GitHub repository](https://github.com/genryianchev/AnnotationServiceBuilder).

---

### License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.



