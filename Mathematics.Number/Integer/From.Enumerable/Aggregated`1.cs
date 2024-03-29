using Tumbleweed.Mathematics.Number.Integer.Property.Value;
using Tumbleweed.Property.Output.From.Enumerable;

namespace Tumbleweed.Mathematics.Number.Integer.From.Enumerable;

public sealed class Aggregated<TFrom> : Tumbleweed.Mathematics.Number.Integer.Envelope
{
	public Aggregated
	(
		IEnumerable<TFrom> from,
		Any seed,
		Func<Any, TFrom, Any> expression
	) : base
	(
		new Actual(
			new Aggregated<TFrom, Any>(
				from, 
				seed,
				expression))
	)
	{
	}
}