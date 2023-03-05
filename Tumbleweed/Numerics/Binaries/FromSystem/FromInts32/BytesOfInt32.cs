using Tumbleweed.Bits;
using Tumbleweed.Bytes.FromSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromInts32;

public sealed class BytesOfInt32 : EnumerableEnvelope<IEnumerable<IBit>>
{
	public BytesOfInt32(IScalar<Int32> integer) : base
	(
		new BytesFromSystem(
			new EnumerableOfDelegate<Byte>(
				() => BitConverter.GetBytes(integer.Value)))
	)
	{
	}
}