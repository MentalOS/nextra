using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NExtra.Extensions
{
	/// <summary>
	/// Extension methods for System.Reflection.Assembly.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://danielsaidi.github.com/nextra
    /// </remarks>
	public static class Assembly_TypeExtensions
	{
	    /// <summary>
        /// Get all types within a certain assembly that inherit a certain base type.
        /// </summary>
        public static IEnumerable<Type> GetTypesThatInherit(this Assembly assembly, Type baseType)
        {
            return assembly.GetTypes().Where(type => type.IsSubclassOf(baseType));
        }

        /// <summary>
        /// Get all types within certain assemblies that inherit a certain base type.
        /// </summary>
        public static IEnumerable<Type> GetTypesThatInherit(this IEnumerable<Assembly> assemblies, Type baseType)
        {
            var result = new List<Type>();

            foreach (var assembly in assemblies)
                result.AddRange(assembly.GetTypesThatInherit(baseType));

            return result;
        }

        /// <summary>
        /// Get all types within a certain assembly that implement a certain interface.
        /// </summary>
        public static IEnumerable<Type> GetTypesThatImplement(this Assembly assembly, Type @interface)
        {
            return assembly.GetTypes().Where(type => @interface.IsAssignableFrom(type) && @interface.FullName != type.FullName);
        }

        /// <summary>
        /// Get all types within certain assemblies that implement a certain interface.
        /// </summary>
        public static IEnumerable<Type> GetTypesThatImplement(this IEnumerable<Assembly> assemblies, Type @interface)
        {
            var result = new List<Type>();

            foreach (var assembly in assemblies)
                result.AddRange(assembly.GetTypesThatImplement(@interface));

            return result;
        }
	}
}
