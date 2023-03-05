using Tumbleweed.Enumerables;

namespace Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;

public sealed class Ints32FromSigneds : EnumerableEnvelope<Int32>
{
	public Ints32FromSigneds(params ISignedInteger[] integers) : this
	(
		new EnumerableWithElements<ISignedInteger>(integers)
	)
	{
	}

	public Ints32FromSigneds(IEnumerable<ISignedInteger> integers) : base
	(
		new SelectedByExpression<ISignedInteger, Int32>(
			integers,
			integer => new Int32FromSigned(integer).Value)
	)
	{
	}

}