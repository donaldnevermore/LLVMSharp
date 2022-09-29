// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/llvm/llvm-project/tree/llvmorg-15.0.0/llvm/include/llvm-c
// Original source is Copyright (c) the LLVM Project and Contributors. Licensed under the Apache License v2.0 with LLVM Exceptions. See NOTICE.txt in the project root for license information.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace LLVMSharp.Interop.UnitTests;

/// <summary>Provides validation of the <see cref="LLVMOrcOpaqueIndirectStubsManager" /> struct.</summary>
public static unsafe partial class LLVMOrcOpaqueIndirectStubsManagerTests
{
    /// <summary>Validates that the <see cref="LLVMOrcOpaqueIndirectStubsManager" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<LLVMOrcOpaqueIndirectStubsManager>(), Is.EqualTo(sizeof(LLVMOrcOpaqueIndirectStubsManager)));
    }

    /// <summary>Validates that the <see cref="LLVMOrcOpaqueIndirectStubsManager" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(LLVMOrcOpaqueIndirectStubsManager).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="LLVMOrcOpaqueIndirectStubsManager" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(LLVMOrcOpaqueIndirectStubsManager), Is.EqualTo(1));
    }
}
