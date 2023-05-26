using Tumbleweed._Boolean.FromEnumerable;
using Tumbleweed._Enumerable;

namespace Tumbleweed._Boolean.Algebra;

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