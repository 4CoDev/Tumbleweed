using Tumbleweed.Scalar;

namespace Tumbleweed._Boolean.FromByte.FromSystem;

public sealed class BooleanWithIndex : BooleanEnvelope
{
	public BooleanWithIndex(IScalar<Byte> @byte, Int32 index) : this
	(
		@byte, new ScalarValue<Int32>(index)
	)
	{
	}
	
	public BooleanWithIndex(IScalar<Byte> @byte, IScalar<Int32> index) : base
	(
		new BooleanOfScalar(
			new Scalar.BitWithIndex(@byte, index))
	)
	{
	}
}