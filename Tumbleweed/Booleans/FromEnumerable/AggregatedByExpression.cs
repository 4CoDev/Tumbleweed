using Tumbleweed.Delegates.Functions.Binary;

namespace Tumbleweed.Booleans.FromEnumerable;

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
		IBinaryFunction<IBoolean, IBoolean, IBoolean> expression
	) : base
	(
		new BooleanOfScalar(
			new Scalars.FromEnumerable.AggregatedByExpression<IBoolean>(
				from,
				expression))
	)
	{
	}
}