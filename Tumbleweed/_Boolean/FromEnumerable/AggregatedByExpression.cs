using Tumbleweed.Subroutine.Binary.Function;

namespace Tumbleweed._Boolean.FromEnumerable;

public sealed class AggregatedByExpression
	: BooleanEnvelope
{
	public AggregatedByExpression
	(
		IEnumerable<IBoolean> from,
		Func<IBoolean, IBoolean, IBoolean> expression
	) : this
	(
		from,
		new FunctionFromSystem<IBoolean, IBoolean, IBoolean>(expression)
	)
	{
	}
	
	public AggregatedByExpression
	(
		IEnumerable<IBoolean> from,
		IFunction<IBoolean, IBoolean, IBoolean> expression
	) : base
	(
		new BooleanOfScalar(
			new Scalar.FromEnumerable.AggregatedByExpression<IBoolean>(
				from,
				expression))
	)
	{
	}
}