using Tumbleweed.Boolean.Scalar;
using Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Boolean.FromByte.FromSystem;

public sealed class BooleanWithIndex : Envelope
{
	public BooleanWithIndex(Any<System::Byte> @byte, Int32 index) : this
	(
		@byte, new Tumbleweed.Scalar.Of.Value<Int32>(index)
	)
	{
	}
	
	public BooleanWithIndex(Any<System::Byte> @byte, Any<Int32> index) : base
	(
		new Value(
			new Scalar.BitWithIndex(@byte, index))
	)
	{
	}
}