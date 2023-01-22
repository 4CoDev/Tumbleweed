using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.WithSystem.FromBytes;

public sealed class BitWithPosition : BitEnvelope
{
	public BitWithPosition(IScalar<byte> @byte, IScalar<int> position) : base
	(
		new BitOfScalar(
			new Scalar.BitWithPosition(@byte, position))
	)
	{
	}
}