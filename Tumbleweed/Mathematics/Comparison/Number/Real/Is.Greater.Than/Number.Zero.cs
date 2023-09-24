using Tumbleweed.Mathematics.Comparison.Number.Real.Is.Greater.Than;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real.Comparison.Is.Greater.Than;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.Comparison.Is.Greater.Than.Number;

public sealed class Zero : Boolean.Envelope
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