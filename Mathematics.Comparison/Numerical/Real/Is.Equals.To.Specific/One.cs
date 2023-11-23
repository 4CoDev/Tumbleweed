using Tumbleweed.Mathematics.Number.Real;
using Envelope = Tumbleweed.Mathematics.Boolean.Envelope;

namespace Tumbleweed.Mathematics.Comparison.Numerical.Real.Is.Equals.To.Specific;

public sealed class One : Envelope
{
	public One
	(
		Any first,
		Any second
	) : base
	(
		new Mathematics.Number.Real.Binary.Precision.Single.System.Comparison.Is.Equals.To.Other.One(
			new Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(first),
			new Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(second))
	)
	{
	}
}