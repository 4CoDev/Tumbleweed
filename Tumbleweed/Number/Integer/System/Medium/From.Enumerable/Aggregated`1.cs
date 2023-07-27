using TW = Tumbleweed;

namespace Tumbleweed.Number.Integer.System.Medium.From.Enumerable;

public sealed class Aggregated<TFrom> : TW.Scalar.Envelope<Int32>
{
	public Aggregated
	(
		IEnumerable<TFrom> from,
		TW.Scalar.Any<Int32> seed,
		Func<TW.Scalar.Any<Int32>, TFrom, TW.Scalar.Any<Int32>> expression
	) : base
	(
		new TW.Scalar.Of.Nested<Int32>(
			new TW.Scalar.From.Enumerable.Aggregated<TFrom, TW.Scalar.Any<Int32>>(
				from,
				seed,
				expression))
	)
	{
	}
}