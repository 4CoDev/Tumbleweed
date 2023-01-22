using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.WithSystem.FromBytes.Scalar;

public sealed class BitsFromByte : IScalar<IEnumerable<IBit>>
{
	public BitsFromByte(IScalar<byte> @byte)
	{
		this.@byte = @byte;
	}

	public IEnumerable<IBit> Value()
	{
		for (int position = 0; position < new BitCountInByte().Value(); position++)
		{
			yield return new FromBytes.BitWithPosition(
				@byte,
				new ScalarOfValue<int>(position));
		}
	}

	private readonly IScalar<byte> @byte;
}