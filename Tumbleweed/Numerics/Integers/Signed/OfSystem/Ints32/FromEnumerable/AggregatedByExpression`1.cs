using Tumbleweed.Scalars;
using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Numerics.Integers.Signed.OfSystem.Ints32.FromEnumerable;

public sealed class AggregatedByExpression<TFrom>
	: ScalarEnvelope<Int32>
{
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		IScalar<Int32> seed,
		Func<IScalar<Int32>, TFrom, IScalar<Int32>> func
	) : base
	(
		new ScalarOfDoubleScalar<Int32>(
			new AggregatedByExpression<TFrom, IScalar<Int32>>(from, seed, func))
	)
	{
	}
}