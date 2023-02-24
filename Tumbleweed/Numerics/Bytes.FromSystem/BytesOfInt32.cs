using Tumbleweed.Bits;
using Tumbleweed.Bytes.FromSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Bytes.FromSystem;

public sealed class BytesOfInt32 : EnumerableEnvelope<IEnumerable<IBit>>
{
	public BytesOfInt32(IScalar<int> integer) : base
	(
		new BytesFromSystem(
			new EnumerableOfDelegate<byte>(
				() => BitConverter.GetBytes(integer.Value)))
	)
	{
	}
}