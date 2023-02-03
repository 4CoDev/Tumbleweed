using Tumbleweed.Bits.FromSystem;
using Tumbleweed.Numerics.Integers.OfSystem.Ints32;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.FromBytes.FromSystem.Scalar;

public sealed class BitWithIndex : IScalar<IBit>
{
	public BitWithIndex(IScalar<byte> @byte, IScalar<int> index)
	{
		this.@byte = @byte;
		this.index = index;
	}
	
	public IBit Value()
	{
		IScalar<int> positive = new PositiveNumber(index);
		IScalar<int> bounded = new LessThenNumber(positive, new NumberOfBits());
		return new BitFromBoolean(
			new ScalarOfDelegate<bool>(
				() => (@byte.Value() & (1 << bounded.Value())) != 0));
	}
	
	private readonly IScalar<byte> @byte;
	
	private readonly IScalar<int> index;
}