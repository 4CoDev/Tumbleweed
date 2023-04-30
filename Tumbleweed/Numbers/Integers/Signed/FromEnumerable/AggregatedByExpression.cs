using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Numbers.Integers.Signed.FromEnumerable;

public sealed class AggregatedByExpression<TFrom> : SignedEnvelope
{
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		ISigned seed,
		Func<ISigned, TFrom, ISigned> func
	) : base
	(
		new SignedOfScalar(
			new AggregatedByExpression<TFrom, ISigned>(from, seed, func))
	)
	{
	}
}