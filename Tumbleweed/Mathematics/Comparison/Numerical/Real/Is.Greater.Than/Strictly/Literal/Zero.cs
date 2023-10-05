using Tumbleweed.Mathematics.Comparison.Numerical.Real.Is.Greater.Than.Strictly.Specific;
using Tumbleweed.Mathematics.Number.Real;
using Envelope = Tumbleweed.Mathematics.Boolean.Envelope;

namespace Tumbleweed.Mathematics.Comparison.Numerical.Real.Is.Greater.Than.Strictly.Literal;

public sealed class Zero : Envelope
{
	public Zero
	(
		Any greater
	) : base
	(
		new One(
			greater,
			new Mathematics.Number.Real.Binary.Precision.Single.From.System.One(0))
	)
	{
	}
}