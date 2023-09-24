using Tumbleweed.Mathematics.Number.Integer.System.Medium.Is.Positive;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using One = Tumbleweed.Mathematics.Number.Integer.System.Medium.Less.Then.One;
using System = System;

namespace Tumbleweed.Mathematics.Boolean.FromByte.FromSystem.Scalar;

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
				new Actual<global::System.Boolean>(
					() => (@byte.Value & (1 << bounded.Value)) != 0));
		}
	}

	private readonly Any<System::Byte> @byte;
	
	private readonly Any<Int32> index;
}