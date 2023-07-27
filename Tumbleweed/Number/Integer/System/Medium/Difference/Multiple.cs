using TW = Tumbleweed;

namespace Tumbleweed.Number.Integer.System.Medium.Difference;

public sealed class Multiple : TW.Scalar.Envelope<Int32>
{
	public Multiple
	(
		IEnumerable<TW.Scalar.Any<Int32>> integers
	) : base
	(
		new Medium.From.Enumerable.Aggregated(
			integers,
			new TW.Scalar.Of.Value<Int32>(0),
			Expression)
	)
	{
	}

	private static TW.Scalar.Any<Int32> Expression
	(
		TW.Scalar.Any<Int32> left,
		TW.Scalar.Any<Int32> right
	) =>
	(
		new Difference.Two(left, right)
	);
}