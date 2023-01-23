using Tumbleweed.Scalars;
using Tumbleweed.WithSystem.Numerics.Ints32;

namespace Tumbleweed.Bits.WithSystem.FromBytes.Scalar;

public sealed class BitWithPosition : IScalar<IBit>
{
	public BitWithPosition(IScalar<byte> @byte, IScalar<int> position)
	{
		this.@byte = @byte;
		this.position = position;
	}
	
	public IBit Value()
	{
		IScalar<int> positive = new PositiveNumber(position);
		IScalar<int> bounded = new LessThenNumber(positive, new BitCountInByte());
		return new BitFromBoolean(
			new ScalarOfDelegate<bool>(
				() => (@byte.Value() & (1 << bounded.Value())) != 0));
	}
	
	private readonly IScalar<byte> @byte;
	
	private readonly IScalar<int> position;
}