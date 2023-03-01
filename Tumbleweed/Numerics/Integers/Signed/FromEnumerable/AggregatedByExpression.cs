using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Numerics.Integers.Signed.FromEnumerable;

public sealed class AggregatedByExpression<TFrom> : SignedEnvelope
{
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		ISignedInteger seed,
		Func<ISignedInteger, TFrom, ISignedInteger> func
	) : base
	(
		new SignedOfScalar(
			new AggregatedByExpression<TFrom, ISignedInteger>(from, seed, func))
	)
	{
	}
}