using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Comparison.Numerical.Real.Is.Greater.Than.Strictly.Specific;

public sealed class One : Mathematics.Boolean.Envelope
{
	public One
	(
		Any first,
		Any second
	) : base
	(
		new Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Comparison.Is.Greater.Than.Other.One(
			new Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(first),
			new Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(second))
	)
	{
	}
}