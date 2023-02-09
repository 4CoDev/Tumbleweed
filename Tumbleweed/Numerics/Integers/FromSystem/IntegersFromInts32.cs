using Tumbleweed.Enumerables;

namespace Tumbleweed.Numerics.Integers.FromSystem;

public class IntegersFromInts32 : EnumerableEnvelope<IInteger>
{
	public IntegersFromInts32(params int[] ints) : this
	(
		new EnumerableWithElements<int>(ints)
	)
	{
	}

	public IntegersFromInts32(IEnumerable<int> ints) : base
	(
		new SelectedByExpression<int, IInteger>(
			ints,
			@int => new IntegerFromInt32(@int))
	)
	{
	}
}