using Tumbleweed.Boolean.Scalar;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using System = System;
using Value = Tumbleweed.Boolean.Scalar.Value;

namespace Tumbleweed.Boolean.FromByte.FromSystem;

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
		new Value(
			new Scalar.BitWithIndex(@byte, index))
	)
	{
	}
}