using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Integer.Signed.OfSystem._Int32.FromEnumerable;

public sealed class AggregatedByExpression : ScalarEnvelope<Int32>
{
	public AggregatedByExpression
	(
		IEnumerable<IScalar<Int32>> from,
		IScalar<Int32> seed,
		Func<IScalar<Int32>, IScalar<Int32>, IScalar<Int32>> func
	) : base
	(
		new AggregatedByExpression<IScalar<Int32>>(from, seed, func)
	)
	{
	}
}