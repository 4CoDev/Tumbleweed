using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Numerics.Integers.Signed.FromSystem;

namespace Tumbleweed.Numerics.Integers.Natural.FromSystem;

public class NaturalsFromInts32 : EnumerableEnvelope<INaturalInteger>
{
	public NaturalsFromInts32(params int[] ints) : this
	(
		new EnumerableWithElements<int>(ints)
	)
	{
	}

	public NaturalsFromInts32(IEnumerable<int> ints) : base
	(
		new SelectedByExpression<int, INaturalInteger>(
			ints,
			@int => new NaturalFromInt32(@int))
	)
	{
	}
}