// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
namespace System.Runtime.CompilerServices
{
    // Consider the following C++ method prototypes:
    // 1) int foo(int ^arg);
    // 2) int foo(int &arg);
    //
    // Both of these methods will have a .NET type signature that looks the
    // same, but when importing a method from a metadata scope, the compiler 
    // needs to know what the calling syntax should be.  This modopt and its 
    // partner "IsExplicitlyDereferenced" disambiguate reference versus
    // pointer arguments.
    //
    // Indicates that the modified GC reference represents a reference in a
    // method signature.
    public static class IsImplicitlyDereferenced
    {
    }
}
