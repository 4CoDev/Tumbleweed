using Tumbleweed.Mathematics.Number.Real.Property;
using Tumbleweed.Property.Output.From.Enumerable;

namespace Tumbleweed.Mathematics.Number.Real.From.Enumerable;

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