using TW = Tumbleweed;

namespace Tumbleweed.Number.Integer.System.Medium.From.Enumerable;

public sealed class Aggregated : TW.Scalar.Envelope<Int32>
{
	public Aggregated
	(
		IEnumerable<TW.Scalar.Any<Int32>> from,
		TW.Scalar.Any<Int32> seed,
		Func<TW.Scalar.Any<Int32>, TW.Scalar.Any<Int32>, TW.Scalar.Any<Int32>>
			expression
	) : base
	(
		new Aggregated<TW.Scalar.Any<Int32>>(from, seed, expression)
	)
	{
	}
}