using Tumbleweed.Bits.FromSystem;
using Tumbleweed.Numerics.Integers.Signed.OfSystem.Ints32;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.FromBytes.FromSystem.Scalar;

public sealed class BitWithIndex : IScalar<IBit>
{
	public BitWithIndex(IScalar<byte> @byte, IScalar<int> index)
	{
		this.@byte = @byte;
		this.index = index;
	}

	public IBit Value
	{
		get
		{
			IScalar<int> positive = new PositiveInt32(index);
			IScalar<int> bounded = new LessThenInt32(positive, new NumberOfBits());
			return new BitFromBoolean(
				new ValueOfDelegate<bool>(
					() => (@byte.Value & (1 << bounded.Value)) != 0));
		}
	}

	private readonly IScalar<byte> @byte;
	
	private readonly IScalar<int> index;
}