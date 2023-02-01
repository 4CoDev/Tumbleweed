using Tumbleweed.Bits;
using Tumbleweed.Scalars;

namespace TumbleSystem.Bits.FromBytes.FromSystem;

public sealed class BitWithIndex : BitEnvelope
{
	public BitWithIndex(IScalar<byte> @byte, int index) : this
	(
		@byte, new ScalarOfValue<int>(index)
	)
	{
	}
	
	public BitWithIndex(IScalar<byte> @byte, IScalar<int> index) : base
	(
		new BitOfScalar(
			new Scalar.BitWithIndex(@byte, index))
	)
	{
	}
}