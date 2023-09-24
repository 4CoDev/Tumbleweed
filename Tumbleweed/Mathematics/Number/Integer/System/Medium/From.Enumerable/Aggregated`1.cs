using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.From.Enumerable;
using Tumbleweed.Scalar.Immutable.Nested;

namespace Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Enumerable;

public sealed class Aggregated<TFrom> : Envelope<Int32>
{
	public Aggregated
	(
		IEnumerable<TFrom> from,
		Any<Int32> seed,
		Func<Any<Int32>, TFrom, Any<Int32>> expression
	) : base
	(
		new Value<Int32>(
			new Aggregated<TFrom, Any<Int32>>(
				from,
				seed,
				expression))
	)
	{
	}
}