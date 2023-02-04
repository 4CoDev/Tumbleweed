using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.ToSystem.Ints32;

public sealed class Ints32FromIntegers : EnumerableEnvelope<int>
{
	public Ints32FromIntegers(params IInteger[] integers) : this
	(
		new EnumerableWithElements<IInteger>(integers)
	)
	{
	}

	public Ints32FromIntegers(IEnumerable<IInteger> integers) : base
	(
		new SelectedByExpression<IInteger, int>(
			integers,
			integer => new Int32FromInteger(integer).Value())
	)
	{
	}

}