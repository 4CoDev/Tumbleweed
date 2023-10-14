
using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;
using System = System;

namespace Tumbleweed.Mathematics.Number.Integer.System.Medium;

public sealed class Bits : Enumerable.Envelope<Boolean.Any>
{
	public Bits(System::Int32 integer) : this
	(
		new Value<System::Int32>(integer)
	)
	{
	}
	
	public Bits(Any<System::Int32> integer) : base
	(
		new BitsOfBytes(
			new Bytes(integer))
	)
	{
	}
}