using Tumbleweed.Enumerables;

namespace Tumbleweed.Numbers.Integers.Natural.FromSystem;

public class NaturalsFromInts32 : EnumerableEnvelope<INatural>
{
	public NaturalsFromInts32(params Int32[] ints) : this
	(
		new EnumerableWithElements<Int32>(ints)
	)
	{
	}

	public NaturalsFromInts32(IEnumerable<Int32> ints) : base
	(
		new SelectedByExpression<Int32, INatural>(
			ints,
			@int => new NaturalFromInt32(@int))
	)
	{
	}
}