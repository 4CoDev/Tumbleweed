namespace Tumbleweed.Enumerables;

public sealed class LazySelectedByExpression<T> :
	EnumerableEnvelope<T>
{
	public LazySelectedByExpression
	(
		IEnumerable<T> from,
		Func<T, T> expression
	) : base
	(
		new LazySelectedByExpression<T, T>(from, expression)
	)
	{
	}
}