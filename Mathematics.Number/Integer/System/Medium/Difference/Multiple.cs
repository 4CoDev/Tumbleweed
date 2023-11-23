using Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Enumerable;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;

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
			new One<Int32>(0),
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