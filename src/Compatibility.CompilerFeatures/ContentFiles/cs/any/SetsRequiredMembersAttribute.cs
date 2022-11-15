// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

//copied from
//https://github.com/dotnet/runtime/blob/6233735c37b1af9c182c28c9d74aeac0104785b8/src/libraries/System.Private.CoreLib/src/System/Diagnostics/CodeAnalysis/SetsRequiredMembersAttribute.cs


#if NETSTANDARD2_0 || NETSTANDARD2_1 || NET5_0 || NET6_0 || NET45 || NET452 || NET461 || NET462 || NET47 || NET471 || NET472 || NET48 || NET481
namespace System.Diagnostics.CodeAnalysis;
//namespace System.Runtime; //.CodeAnalysis;

/// <summary>
/// Specifies that this constructor sets all required members for the current type, and callers
/// do not need to set any required members themselves.
/// </summary>
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
#if SYSTEM_PRIVATE_CORELIB
    public
#else
internal
#endif
    sealed class SetsRequiredMembersAttribute : Attribute
{ }

#endif
