using Tumbleweed.Number.Real.Binary.Precision.Single.System;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.Comparison;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.Comparison.Is.Greater.Than;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.Comparison.Is.Greater.Than.Other;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.From;

namespace Tumbleweed.Number.Real.Comparison.Is.Greater.Than;

public sealed class One : Boolean.Envelope
{
	public One
	(
		Real.Any first,
		Real.Any second
	) : base
	(
		new Binary.Precision.Single.System.Comparison.Is.Greater.Than.Other.One(
			new Binary.Precision.Single.System.From.Tumbleweed.One(first),
			new Binary.Precision.Single.System.From.Tumbleweed.One(second))
	)
	{
	}
}