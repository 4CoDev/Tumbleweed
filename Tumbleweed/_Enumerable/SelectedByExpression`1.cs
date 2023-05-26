namespace Tumbleweed._Enumerable;

public sealed class SelectedByExpression<T> : EnumerableEnvelope<T>
{
	public SelectedByExpression
	(
		IEnumerable<T> from,
		Func<T, T> expression
	) : base
	(
		new SelectedByExpression<T, T>(from, expression)
	)
	{
	}
}