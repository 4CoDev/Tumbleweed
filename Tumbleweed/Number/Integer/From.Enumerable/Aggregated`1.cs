using TW = Tumbleweed;

namespace Tumbleweed.Number.Integer.From.Enumerable;

public sealed class Aggregated<TFrom> : Integer.Envelope
{
	public Aggregated
	(
		IEnumerable<TFrom> from,
		Integer.Any seed,
		Func<Integer.Any, TFrom, Integer.Any> expression
	) : base
	(
		new Integer.Scalar.Value(
			new TW.Scalar.From.Enumerable.Aggregated<TFrom, Integer.Any>(
				from, 
				seed,
				expression))
	)
	{
	}
}