using Tumbleweed.Booleans;
using Tumbleweed.Bytes;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Integers.Signed.ToSystem.Ints32;

public sealed class Int32FromBits : ScalarEnvelope<Int32>
{
	public Int32FromBits(IEnumerable<IBoolean> bits) : base
	(
		new Int32FromBytes(
			new BytesFromBits(
				new EnumerableWithSize<IBoolean>(bits, 32)))
	)
	{
	}
}