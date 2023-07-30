using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using TW = Tumbleweed;

namespace Tumbleweed.Number.Integer.System.Medium.Difference;

public sealed class Multiple : Envelope<Int32>
{
	public Multiple
	(
		IEnumerable<Any<Int32>> integers
	) : base
	(
		new Medium.From.Enumerable.Aggregated(
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