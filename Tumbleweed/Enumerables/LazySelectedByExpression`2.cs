namespace Tumbleweed.Enumerables;

public sealed class LazySelectedByExpression<TFrom, TTo> :
	EnumerableEnvelope<TTo>
{
	public LazySelectedByExpression
	(
		IEnumerable<TFrom> from,
		Func<TFrom, TTo> expression
	) : base
	(
		new LazyEnumerable<TTo>(
			new SelectedByExpression<TFrom, TTo>(from, expression))
	)
	{
	}
}