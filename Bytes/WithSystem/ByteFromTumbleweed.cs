using Tumbleweed.Bits;
using Tumbleweed.Bits.WithSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bytes.WithSystem;

public sealed class ByteFromTumbleweed : ScalarEnvelope<byte>
{
	public ByteFromTumbleweed(IEnumerable<IBit> origin) : base
	(
		new ByteFromBooleans(
			new BooleansFromBits(
				new ByteFromBits(origin)))
	)
	{
	}
}