using Tumbleweed.Mathematics.Boolean.Property.Value;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;
using System = System;

namespace Tumbleweed.Mathematics.Boolean.FromByte.FromSystem;

public sealed class BooleanWithIndex : Envelope
{
	public BooleanWithIndex(Any<System::Byte> @byte, Int32 index) : this
	(
		@byte, new One<Int32>(index)
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