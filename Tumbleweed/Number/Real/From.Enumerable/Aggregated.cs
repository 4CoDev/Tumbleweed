using Tumbleweed.Number.Real.Scalar;
using TW = Tumbleweed;

namespace Tumbleweed.Number.Real.From.Enumerable;

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
			new Tumbleweed.Scalar.Immutable.From.Enumerable.Aggregated<Any>(
				from,
				seed,
				expression))
	)
	{
	}
}