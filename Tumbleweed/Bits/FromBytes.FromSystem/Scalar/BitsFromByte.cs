using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.FromBytes.FromSystem.Scalar;

public sealed class BitsFromByte : IScalar<IEnumerable<IBit>>
{
	public BitsFromByte(IScalar<byte> @byte)
	{
		this.@byte = @byte;
	}

	public IEnumerable<IBit> Value
	{
		get
		{
			for (int position = 0; position < new NumberOfBits().Value; position++)
			{
				yield return new FromSystem.BitWithIndex(
					@byte,
					new ScalarOfValue<int>(position));
			}
		}
	}

	private readonly IScalar<byte> @byte;
}