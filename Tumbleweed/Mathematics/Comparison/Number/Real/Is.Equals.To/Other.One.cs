using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System;
using Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Comparison;
using Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Comparison.Is.Equals.To;
using Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Comparison.Is.Equals.To.Other;
using Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.Comparison.Is.Equals.To.Other;

public sealed class One : Boolean.Envelope
{
	public One
	(
		Any first,
		Any second
	) : base
	(
		new Binary.Precision.Single.System.Comparison.Is.Equals.To.Other.One(
			new Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(first),
			new Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(second))
	)
	{
	}
}