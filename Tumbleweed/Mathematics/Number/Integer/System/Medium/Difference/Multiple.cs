using Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Enumerable;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace Tumbleweed.Mathematics.Number.Integer.System.Medium.Difference;

public sealed class Multiple : Envelope<Int32>
{
	public Multiple
	(
		IEnumerable<Any<Int32>> integers
	) : base
	(
		new Aggregated(
			integers,
			new Value<Int32>(0),
			Expression)
	)
	{
	}

	private static Any<Int32> Expression
	(
		Any<Int32> left,
		Any<Int32> right
	) =>
	(
		new Difference.Two(left, right)
	);
}