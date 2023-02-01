namespace Tumbleweed.Scalars.FromEnumerable;

public sealed class AggregatedByExpression<T> : ScalarEnvelope<T>
{
	public AggregatedByExpression
	(
		IEnumerable<T> from,
		T seed,
		Func<T, T, T> func
	) : base
	(
		new AggregatedByExpression<T, T>(from, seed, func)
	)
	{
	}
}