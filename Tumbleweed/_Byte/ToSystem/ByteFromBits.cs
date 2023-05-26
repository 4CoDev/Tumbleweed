using Tumbleweed._Boolean;
using Tumbleweed._Boolean.ToSystem;
using Tumbleweed._Byte.OfSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed._Byte.ToSystem;

public sealed class ByteFromBits : ScalarEnvelope<Byte>
{
	public ByteFromBits(IEnumerable<IBoolean> bits) : base
	(
		new ByteFromBooleans(
			new BooleansFromTumbleweed(
				new _Byte.ByteFromBits(bits)))
	)
	{
	}
}