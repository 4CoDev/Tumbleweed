using Tumbleweed.Number.Integer.System.Medium.Is.Positive;
using Tumbleweed.Scalar;
using One = Tumbleweed.Number.Integer.System.Medium.Less.Then.One;
using System = System;

namespace Tumbleweed.Boolean.FromByte.FromSystem.Scalar;

public sealed class BitWithIndex : Any<Any>
{
	public BitWithIndex(Any<System::Byte> @byte, Any<Int32> index)
	{
		this.@byte = @byte;
		this.index = index;
	}

	public Any Value
	{
		get
		{
			Any<Int32> positive = new Statement(index);
			Any<Int32> bounded = new One(positive, new NumberOfBits());
			return new From.System.One(
				new Tumbleweed.Scalar.Function.Result<global::System.Boolean>(
					() => (@byte.Value & (1 << bounded.Value)) != 0));
		}
	}

	private readonly Any<System::Byte> @byte;
	
	private readonly Any<Int32> index;
}