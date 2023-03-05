using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Numerics.Integers.Signed.FromSystem;

namespace Tumbleweed.Numerics.Integers.Natural.FromSystem;

public class NaturalsFromInts32 : EnumerableEnvelope<INaturalInteger>
{
	public NaturalsFromInts32(params Int32[] ints) : this
	(
		new EnumerableWithElements<Int32>(ints)
	)
	{
	}

	public NaturalsFromInts32(IEnumerable<Int32> ints) : base
	(
		new SelectedByExpression<Int32, INaturalInteger>(
			ints,
			@int => new NaturalFromInt32(@int))
	)
	{
	}
}