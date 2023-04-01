using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.FromBytes.FromSystem.Scalar;

public sealed class BitsFromByte : IScalar<IEnumerable<IBit>>
{
	public BitsFromByte(IScalar<Byte> @byte)
	{
		this.@byte = @byte;
	}

	public IEnumerable<IBit> Value
	{
		get
		{
			for (Int32 position = 0; position < new NumberOfBits().Value; position++)
			{
				yield return new FromSystem.BitWithIndex(
					@byte,
					new ScalarValue<Int32>(position));
			}
		}
	}

	private readonly IScalar<Byte> @byte;
}