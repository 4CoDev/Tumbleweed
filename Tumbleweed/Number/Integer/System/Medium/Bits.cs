using Tumbleweed.Boolean;
using Boolean = Tumbleweed.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Integer = Tumbleweed.Number.Integer.System.Medium;

namespace Tumbleweed.Number.Integer.System.Medium;

public sealed class Bits : Enumerable.Envelope<Boolean.Any>
{
	public Bits(System::Int32 integer) : this
	(
		new Scalar::Of.Value<System::Int32>(integer)
	)
	{
	}
	
	public Bits(Scalar::Any<System::Int32> integer) : base
	(
		new BitsOfBytes(
			new Integer::Bytes(integer))
	)
	{
	}
}