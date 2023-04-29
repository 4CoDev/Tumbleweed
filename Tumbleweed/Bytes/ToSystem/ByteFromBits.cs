using Tumbleweed.Booleans;
using Tumbleweed.Booleans.ToSystem;
using Tumbleweed.Bytes.OfSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bytes.ToSystem;

public sealed class ByteFromBits : ScalarEnvelope<Byte>
{
	public ByteFromBits(IEnumerable<IBoolean> bits) : base
	(
		new ByteFromBooleans(
			new BooleansFromTumbleweed(
				new Tumbleweed.Bytes.ByteFromBits(bits)))
	)
	{
	}
}