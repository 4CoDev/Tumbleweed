using Tumbleweed.Scalar.FromEnumerable;
using Tumbleweed.Subroutine.Function.Binary;

namespace Tumbleweed._Boolean.FromEnumerable;

public sealed class AggregatedByExpression<TFrom>
	: BooleanEnvelope
{
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		IBoolean seed,
		Func<IBoolean, TFrom, IBoolean> expression
	) : this
	(
		from,
		seed,
		new FunctionFromSystem<IBoolean, TFrom, IBoolean>(expression)
	)
	{
	}
	
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		IBoolean seed,
		IFunction<IBoolean, TFrom, IBoolean> 
		expression
	) : base
	(
		new BooleanOfScalar(
			new AggregatedByExpression<TFrom, IBoolean>(
				from,
				seed,
				expression))
	)
	{
	}
}