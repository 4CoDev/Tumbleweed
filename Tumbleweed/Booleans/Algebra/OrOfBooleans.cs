using Tumbleweed.Booleans.FromEnumerable;
using Tumbleweed.Booleans.FromSystem;
using Tumbleweed.Enumerables;

namespace Tumbleweed.Booleans.Algebra;

public sealed class OrOfBooleans : BooleanEnvelope
{
	public OrOfBooleans(params IBoolean[] booleans) : this
	(
		new EnumerableWithElements<IBoolean>(booleans)
	)
	{
	}
	
	public OrOfBooleans(IEnumerable<IBoolean> booleans) : base
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
		new OrOfTwoBooleans(first, second)
	);
}