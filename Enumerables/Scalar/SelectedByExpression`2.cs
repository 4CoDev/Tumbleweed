using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.Scalar;

public sealed class SelectedByExpression<TFrom, TTo>
	: IScalar<IEnumerable<TTo>>
{
	public SelectedByExpression
	(
		IEnumerable<TFrom> from,
		Func<TFrom, TTo> expression
	)
	{
		this.from = from;
		this.expression = expression;
	}
	
	public IEnumerable<TTo> Value()
	{
		return from.Select(item => expression(item));
	}

	private readonly IEnumerable<TFrom> from;

	private readonly Func<TFrom, TTo> expression;
}