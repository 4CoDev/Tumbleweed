using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed.OfSystem.Ints32.FromEnumerable;

public sealed class AggregatedByExpression : ScalarEnvelope<int>
{
	public AggregatedByExpression
	(
		IEnumerable<IScalar<int>> from,
		IScalar<int> seed,
		Func<IScalar<int>, IScalar<int>, IScalar<int>> func
	) : base
	(
		new AggregatedByExpression<IScalar<int>>(from, seed, func)
	)
	{
	}
}