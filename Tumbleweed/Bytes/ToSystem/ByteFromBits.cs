using Tumbleweed.Bits;
using Tumbleweed.Bits.ToSystem;
using Tumbleweed.Bytes.OfSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bytes.ToSystem;

public sealed class ByteFromBits : ScalarEnvelope<Byte>
{
	public ByteFromBits(IEnumerable<IBit> bits) : base
	(
		new ByteFromBooleans(
			new BooleansFromBits(
				new Tumbleweed.Bytes.ByteFromBits(bits)))
	)
	{
	}
}