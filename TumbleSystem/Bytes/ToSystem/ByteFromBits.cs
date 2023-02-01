using TumbleSystem.Bits.ToSystem;
using TumbleSystem.Bytes.OfSystem;
using Tumbleweed.Bits;
using Tumbleweed.Scalars;

namespace TumbleSystem.Bytes.ToSystem;

public sealed class ByteFromBits : ScalarEnvelope<byte>
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