#region License
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

//copied from
//https://github.com/dotnet/roslyn/blob/55a5f3a13fd7660fc3e59f8f71b058642916edc3/src/Compilers/Core/Portable/InternalUtilities/IsExternalInit.cs#L17
#endregion

#pragma warning disable IDE0073
#if NETSTANDARD2_0 || NETSTANDARD2_1 || NET45 || NET452 || NET461 || NET462 || NET47 || NET471 || NET472 || NET48 || NET481
namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Reserved to be used by the compiler for tracking metadata.
    /// This class should not be used by developers in source code.
    /// </summary>
    //[EditorBrowsable(EditorBrowsableState.Never)]
    internal static class IsExternalInit
    {
    }
}

#endif
