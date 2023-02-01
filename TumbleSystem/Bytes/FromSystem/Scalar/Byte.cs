using TumbleSystem.Bits.FromBytes.FromSystem;
using Tumbleweed.Bits;
using Tumbleweed.Scalars;

namespace TumbleSystem.Bytes.FromSystem.Scalar;

public sealed class Byte : IScalar<IEnumerable<IBit>>
{
	public Byte(IScalar<byte> @byte)
	{
		this.@byte = @byte;
	}

	public IEnumerable<IBit> Value()
	{
		for (int index = 0; index < 8; index++)
		{
			yield return new BitWithIndex(@byte, index);
		}
	}

	private readonly IScalar<byte> @byte;
}