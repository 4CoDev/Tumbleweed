using Tumbleweed.Scalars;
using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.System.Numerics.Ints32.FromEnumerable;

public sealed class AggregatedByExpression<TFrom>
	: ScalarEnvelope<int>
{
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		IScalar<int> seed,
		Func<IScalar<int>, TFrom, IScalar<int>> func
	) : base
	(
		new ScalarOfDoubleScalar<int>(
			new AggregatedByExpression<TFrom, IScalar<int>>(from, seed, func))
	)
	{
	}
}