using Tumbleweed.Booleans;
using Tumbleweed.Bytes.FromSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Binaries.FromSystem.FromInts32;

public sealed class BytesOfInt32 : EnumerableEnvelope<IEnumerable<IBoolean>>
{
	public BytesOfInt32(IScalar<Int32> integer) : base
	(
		new BytesFromSystem(
			new EnumerableOfFunction<Byte>(
				() => BitConverter.GetBytes(integer.Value)))
	)
	{
	}
}