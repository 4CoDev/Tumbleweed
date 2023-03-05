using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.FromBytes.FromSystem;

public sealed class BitWithIndex : BitEnvelope
{
	public BitWithIndex(IScalar<Byte> @byte, Int32 index) : this
	(
		@byte, new ScalarOfValue<Int32>(index)
	)
	{
	}
	
	public BitWithIndex(IScalar<Byte> @byte, IScalar<Int32> index) : base
	(
		new BitOfScalar(
			new Scalar.BitWithIndex(@byte, index))
	)
	{
	}
}