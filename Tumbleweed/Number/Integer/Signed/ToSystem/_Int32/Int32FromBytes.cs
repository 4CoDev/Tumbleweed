using Tumbleweed._Boolean;
using Tumbleweed._Byte.ToSystem;
using Tumbleweed._Enumerable.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Integer.Signed.ToSystem._Int32;

public sealed class Int32FromBytes : ScalarEnvelope<Int32>
{
	public Int32FromBytes(IEnumerable<IEnumerable<IBoolean>> bytes) : base
	(
		new OfSystem._Int32.Int32FromBytes(
			new EnumerableWithSize<Byte>(
				new BytesFromChunkedBits(bytes),
				4))
	)
	{
	}
}