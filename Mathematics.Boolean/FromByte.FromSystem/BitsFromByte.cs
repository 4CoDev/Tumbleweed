using Tumbleweed.Enumerable.Property;
using Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.Mathematics.Boolean.FromByte.FromSystem;

public sealed class BitsFromByte : Enumerable.Envelope<Any>
{
	public BitsFromByte(System::Byte @byte) : this
	(
		new Tumbleweed.Property.Output.With.Value.One<System::Byte>(@byte)
	)
	{
	}
	
	public BitsFromByte(Any<System::Byte> @byte) : base
	(
		new Value<Any>(
				new Scalar.BitsFromByte(@byte))
	)
	{
	}
}