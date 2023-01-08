using System;

namespace MediatR.Examples;

public static class TypeExtensions
{
    public static bool IsAssignableTo(this Type type, Type assignableType)
        => assignableType.IsAssignableFrom(type);

    public static bool IsAssignableTo<T>(this Type type)
        => typeof(T).IsAssignableFrom(type);
}