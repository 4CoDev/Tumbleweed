using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable.Scalar;

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

	public IEnumerable<TTo> Value
	{
		get { return from.Select(item => expression(item)); }
	}

	private readonly IEnumerable<TFrom> from;

	private readonly Func<TFrom, TTo> expression;
}