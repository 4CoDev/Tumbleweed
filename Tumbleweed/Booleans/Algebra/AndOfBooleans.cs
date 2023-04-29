using Tumbleweed.Booleans.FromEnumerable;
using Tumbleweed.Enumerables;

namespace Tumbleweed.Booleans.Algebra;

public sealed class AndOfBooleans : BooleanEnvelope
{
	public AndOfBooleans(params IBoolean[] booleans) : this
	(
		new EnumerableWithElements<IBoolean>(booleans)
	)
	{
	}
	
	public AndOfBooleans(IEnumerable<IBoolean> booleans) : base
	(
		new AggregatedByExpression(
			booleans,
			Expression)
	)
	{
	}
	
	private static IBoolean Expression
	(
		IBoolean first,
		IBoolean second
	) =>
	(
		new AndOfTwoBooleans(first, second)
	);
}