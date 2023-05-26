namespace Tumbleweed._Enumerable.Lazy;

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
			new _Enumerable.SelectedByExpression<TFrom, TTo>(from, expression))
	)
	{
	}
}