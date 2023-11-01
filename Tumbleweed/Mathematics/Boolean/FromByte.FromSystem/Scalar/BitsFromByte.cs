using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With;
using System = System;

namespace Tumbleweed.Mathematics.Boolean.FromByte.FromSystem.Scalar;

public sealed class BitsFromByte : Any<IEnumerable<Any>>
{
	public BitsFromByte(Any<System::Byte> @byte)
	{
		this.@byte = @byte;
	}

	public IEnumerable<Any> Value
	{
		get
		{
			for (Int32 position = 0; position < new NumberOfBits().Value; position++)
			{
				yield return new BooleanWithIndex(
					@byte,
					new Value<Int32>(position));
			}
		}
	}

	private readonly Any<System::Byte> @byte;
}