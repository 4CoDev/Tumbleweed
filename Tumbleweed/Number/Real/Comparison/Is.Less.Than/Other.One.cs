using Tumbleweed.Number.Real.Binary.Precision.Single.System;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.Comparison;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.Comparison.Is.Less.Than;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.Comparison.Is.Less.Than.Other;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.From;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Real.Comparison.Is.Less.Than.Other;

public sealed class One : Boolean.Envelope
{
	public One
	(
		Real.Any first,
		Real.Any second
	) : base
	(
		new Binary.Precision.Single.System.Comparison.Is.Less.Than.Other.One(
			new Binary.Precision.Single.System.From.Tumbleweed.One(first),
			new Binary.Precision.Single.System.From.Tumbleweed.One(second))
	)
	{
	}
}