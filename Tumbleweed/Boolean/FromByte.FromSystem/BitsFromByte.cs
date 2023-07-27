using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Scalar;
using Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Boolean.FromByte.FromSystem;

public sealed class BitsFromByte : Enumerable.Envelope<Any>
{
	public BitsFromByte(System::Byte @byte) : this
	(
		new Tumbleweed.Scalar.Of.Value<System::Byte>(@byte)
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