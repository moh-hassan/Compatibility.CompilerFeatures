#region License
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

//https://github.com/dotnet/roslyn/blob/b9dd1a472d6a6d28c77769eb8dada966a703db26/src/Compilers/Core/Portable/InternalUtilities/RequiredMemberAttribute.cs

// Copied from:
// https://github.com/dotnet/runtime/blob/fdd104ec5e1d0d2aa24a6723995a98d0124f724b/src/libraries/System.Private.CoreLib/src/System/Runtime/CompilerServices/RequiredMemberAttribute.cs

#endregion

#if NETSTANDARD2_0 || NETSTANDARD2_1 || NET5_0 || NET6_0 || NET45 || NET452 || NET461 || NET462 || NET47 || NET471 || NET472 || NET48 || NET481
#pragma warning disable IDE0073
namespace System.Runtime.CompilerServices
{
    /// <summary>Specifies that a type has required members or that a member is required.</summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    internal sealed class RequiredMemberAttribute : Attribute
    {
    }
}
#endif
