using Tumbleweed.Bits;
using Tumbleweed.Bits.FromBytes.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bytes.FromSystem.Scalar;

public sealed class Byte : IScalar<IEnumerable<IBit>>
{
	public Byte(IScalar<System.Byte> @byte)
	{
		this.@byte = @byte;
	}

	public IEnumerable<IBit> Value
	{
		get
		{
			for (Int32 index = 0; index < 8; index++)
			{
				yield return new BitWithIndex(@byte, index);
			}
		}
	}

	private readonly IScalar<System.Byte> @byte;
}