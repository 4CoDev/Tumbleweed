using Tumbleweed.Number.Real.Scalar;
using Tumbleweed.Scalar.From.Enumerable;

namespace Tumbleweed.Number.Real.From.Enumerable;

public class Aggregated<TFrom> : Envelope
{
	public Aggregated
	(
		IEnumerable<TFrom> from,
		Any seed,
		Func<Any, TFrom, Any> expression
	) : base
	(
		new Value(
			new Aggregated<TFrom, Any>(from, seed, expression))
	)
	{
	}
}