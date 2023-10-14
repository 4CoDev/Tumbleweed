using Tumbleweed.Mathematics.Boolean.Scalar.Value;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;
using System = System;

namespace Tumbleweed.Mathematics.Boolean.FromByte.FromSystem;

public sealed class BooleanWithIndex : Envelope
{
	public BooleanWithIndex(Any<System::Byte> @byte, Int32 index) : this
	(
		@byte, new Value<Int32>(index)
	)
	{
	}
	
	public BooleanWithIndex(Any<System::Byte> @byte, Any<Int32> index) : base
	(
		new Actual(
			new Scalar.BitWithIndex(@byte, index))
	)
	{
	}
}