namespace Tumbleweed._Enumerable;

public sealed class SelectedByExpression<TFrom, TTo> : EnumerableEnvelope<TTo>
{
	public SelectedByExpression
	(
		IEnumerable<TFrom> from,
		Func<TFrom, TTo> expression
	) : base
	(
		new EnumerableOfScalar<TTo>(
			new Scalar.SelectedByExpression<TFrom, TTo>(from, expression))
	)
	{
	}
}