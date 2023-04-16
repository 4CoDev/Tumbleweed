namespace Tumbleweed.Enumerables.Lazy;

public sealed class SelectedByExpression<TFrom, TTo> :
	EnumerableEnvelope<TTo>
{
	public SelectedByExpression
	(
		IEnumerable<TFrom> from,
		Func<TFrom, TTo> expression
	) : base
	(
		new LazyEnumerable<TTo>(
			new Enumerables.SelectedByExpression<TFrom, TTo>(from, expression))
	)
	{
	}
}