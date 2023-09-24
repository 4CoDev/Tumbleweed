using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace Tumbleweed.Mathematics.Number.Integer.System.Medium.Difference;

public sealed class Two : Envelope<Int32>
{
	public Two
	(
		Any<Int32> left,
		Any<Int32> right
	) : base
	(
		new Actual<Int32>(
			() => left.Value - right.Value)
	)
	{
	}
}