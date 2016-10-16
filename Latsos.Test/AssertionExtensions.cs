using System;
using FluentAssertions.Execution;

namespace Latsos.Test
{
    public static class AssertionExtensions
    {
        /// <summary>
        /// Asserts objects equality using implementation of <see cref="System.IEquatable{T}"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="object1"></param>
        /// <param name="object2"></param>

        public static void ShouldEqual<T>(this T object1, T object2) where T:IEquatable<T>
        {
            if (!object1.Equals(object2))
            {
                throw new AssertionFailedException($"Expected objects to be equal {object1} {object2}");
            }
        }

        /// <summary>
        /// Asserts object inequality using implementation of <see cref="System.IEquatable{T}"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        public static void ShouldNotEqual<T>(this T object1, T object2) where T : IEquatable<T>
        {
            if (object1.Equals(object2))
            {
                throw new AssertionFailedException("objects are equal but they shouldn't be");
            }
        }
    }
}