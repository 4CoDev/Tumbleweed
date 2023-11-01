using Tumbleweed.Mathematics.Number.Real.Property;

namespace Tumbleweed.Mathematics.Number.Real.From.Enumerable;

public class Aggregated : Envelope
{
	public Aggregated
	(
		IEnumerable<Any> from,
		Any seed,
		Func<Any, Any, Any> expression
	) : base
	(
		new Value(
			new Tumbleweed.Property.Output.From.Enumerable.Aggregated<Any>(
				from,
				seed,
				expression))
	)
	{
	}
}