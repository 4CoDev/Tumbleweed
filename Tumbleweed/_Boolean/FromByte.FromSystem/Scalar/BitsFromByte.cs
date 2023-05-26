using Tumbleweed.Scalar;

namespace Tumbleweed._Boolean.FromByte.FromSystem.Scalar;

public sealed class BitsFromByte : IScalar<IEnumerable<IBoolean>>
{
	public BitsFromByte(IScalar<Byte> @byte)
	{
		this.@byte = @byte;
	}

	public IEnumerable<IBoolean> Value
	{
		get
		{
			for (Int32 position = 0; position < new NumberOfBits().Value; position++)
			{
				yield return new BooleanWithIndex(
					@byte,
					new ScalarValue<Int32>(position));
			}
		}
	}

	private readonly IScalar<Byte> @byte;
}