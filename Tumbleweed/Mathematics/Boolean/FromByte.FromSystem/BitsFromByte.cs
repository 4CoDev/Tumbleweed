using Tumbleweed.Enumerable.Scalar;
using Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.Mathematics.Boolean.FromByte.FromSystem;

public sealed class BitsFromByte : Enumerable.Envelope<Any>
{
	public BitsFromByte(System::Byte @byte) : this
	(
		new Tumbleweed.Scalar.Immutable.With.Value<System::Byte>(@byte)
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