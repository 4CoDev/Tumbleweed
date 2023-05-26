using Tumbleweed._Boolean;
using Tumbleweed._Byte;
using Tumbleweed._Enumerable.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Integer.Signed.ToSystem._Int32;

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