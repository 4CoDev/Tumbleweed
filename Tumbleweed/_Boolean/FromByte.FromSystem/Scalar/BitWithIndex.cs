using Tumbleweed._Boolean.FromSystem;
using Tumbleweed.Number.Integer.Signed.OfSystem._Int32;
using Tumbleweed.Scalar;

namespace Tumbleweed._Boolean.FromByte.FromSystem.Scalar;

public sealed class BitWithIndex : IScalar<IBoolean>
{
	public BitWithIndex(IScalar<Byte> @byte, IScalar<Int32> index)
	{
		this.@byte = @byte;
		this.index = index;
	}

	public IBoolean Value
	{
		get
		{
			IScalar<Int32> positive = new PositiveInt32(index);
			IScalar<Int32> bounded = new LessThenInt32(positive, new NumberOfBits());
			return new BooleanFromSystem(
				new ResultOfFunction<Boolean>(
					() => (@byte.Value & (1 << bounded.Value)) != 0));
		}
	}

	private readonly IScalar<Byte> @byte;
	
	private readonly IScalar<Int32> index;
}