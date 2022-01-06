﻿#pragma warning disable CS0169, CS0649, IDE0051 // Field is never used, Field is never assigned to, Remove unused private members
using System;
using System.Runtime.CompilerServices;

namespace LibHac.Common.FixedArrays;

public struct Array1<T>
{
    public const int Length = 1;

    private T _0;

    public ref T this[int i] => ref Items[i];

    public Span<T> Items => SpanHelpers.CreateSpan(ref _0, Length);
    public readonly ReadOnlySpan<T> ItemsRo => SpanHelpers.CreateReadOnlySpan(in _0, Length);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator ReadOnlySpan<T>(in Array1<T> value) => value.ItemsRo;
}