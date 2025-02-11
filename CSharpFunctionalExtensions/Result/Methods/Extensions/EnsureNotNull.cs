#nullable enable

using System;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        public static Result<T> EnsureNotNull<T>(this Result<T?> result, string error)
            where T : class
        {
            return result.Ensure(value => value != null, error).Map(value => value!);
        }

        public static Result<T> EnsureNotNull<T>(this Result<T?> result, string error)
            where T : struct
        {
            return result.Ensure(value => value != null, error).Map(value => value!.Value);
        }

        public static Result<T> EnsureNotNull<T>(this Result<T?> result, Func<string> errorFactory)
            where T : class
        {
            return result.Ensure(value => value != null, _ => errorFactory()).Map(value => value!);
        }

        public static Result<T> EnsureNotNull<T>(this Result<T?> result, Func<string> errorFactory)
            where T : struct
        {
            return result.Ensure(value => value != null, _ => errorFactory()).Map(value => value!.Value);
        }

        public static Result<T, E> EnsureNotNull<T, E>(this Result<T?, E> result, E error)
            where T : class
        {
            return result.Ensure(value => value != null, error).Map(value => value!);
        }

        public static Result<T, E> EnsureNotNull<T, E>(this Result<T?, E> result, E error)
            where T : struct
        {
            return result.Ensure(value => value != null, error).Map(value => value!.Value);
        }

        public static Result<T, E> EnsureNotNull<T, E>(this Result<T?, E> result, Func<E> errorFactory)
            where T : class
        {
            return result.Ensure(value => value != null, _ => errorFactory()).Map(value => value!);
        }

        public static Result<T, E> EnsureNotNull<T, E>(this Result<T?, E> result, Func<E> errorFactory)
            where T : struct
        {
            return result.Ensure(value => value != null, _ => errorFactory()).Map(value => value!.Value);
        }
    }
}
