﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
/// <summary>
/// Utilties for reflection
/// </summary>
public static class ReflectionUtils
{
    /// <summary>
    /// Get all the fields of a class
    /// </summary>
    /// <param name="type">Type object of that class</param>
    /// <returns></returns>
    public static IEnumerable<FieldInfo> GetAllFields(this Type type, Attribute attribute = null)
    {
        if (type == null)
        {
            return Enumerable.Empty<FieldInfo>();
        }

        BindingFlags flags = BindingFlags.Public |
                             BindingFlags.NonPublic |
                             BindingFlags.Static |
                             BindingFlags.Instance |
                             BindingFlags.DeclaredOnly;
        //.Where(p => p.GetCustomAttribute(typeof(DataObjectFieldAttribute)) != null)

        if (attribute != null)
            return type.GetFields(flags).Where(p => p.GetCustomAttribute(attribute.GetType()) != null).Union(GetAllFields(type.BaseType, attribute));
        else
            return type.GetFields(flags).Union(GetAllFields(type.BaseType, attribute));
    }

    /// <summary>
    /// Get all properties of a class
    /// </summary>
    /// <param name="type">Type object of that class</param>
    /// <returns></returns>
    public static IEnumerable<PropertyInfo> GetAllProperties(this Type type)
    {
        if (type == null)
        {
            return Enumerable.Empty<PropertyInfo>();
        }

        BindingFlags flags = BindingFlags.Public |
                             BindingFlags.NonPublic |
                             BindingFlags.Static |
                             BindingFlags.Instance |
                             BindingFlags.DeclaredOnly;

        return type.GetProperties(flags).Union(GetAllProperties(type.BaseType));
    }

    /// <summary>
    /// Get all constructors of a class
    /// </summary>
    /// <param name="type">Type object of that class</param>
    /// <returns></returns>
    public static IEnumerable<ConstructorInfo> GetAllConstructors(this Type type)
    {
        if (type == null)
        {
            return Enumerable.Empty<ConstructorInfo>();
        }

        BindingFlags flags = BindingFlags.Public |
                             BindingFlags.NonPublic |
                             BindingFlags.Static |
                             BindingFlags.Instance |
                             BindingFlags.DeclaredOnly;

        return type.GetConstructors(flags);
    }

    /// <summary>
    /// Get all methods of a class
    /// </summary>
    /// <param name="type">Type object for that class</param>
    /// <returns></returns>
    public static IEnumerable<MethodInfo> GetAllMethods(this Type type)
    {
        if (type == null)
        {
            return Enumerable.Empty<MethodInfo>();
        }

        BindingFlags flags = BindingFlags.Public |
                             BindingFlags.NonPublic |
                             BindingFlags.Static |
                             BindingFlags.Instance |
                             BindingFlags.DeclaredOnly;

        return type.GetMethods(flags).Union(GetAllMethods(type.BaseType));
    }
}