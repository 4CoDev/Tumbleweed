using Tumbleweed.Byte.FromSystem;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;
using Boolean = Tumbleweed.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Number.Integer.System.Medium;

public sealed class Bytes :
	Envelope<IEnumerable<Boolean.Any>>
{
	public Bytes(System::Int32 integer) : this
	(
		new Scalar::Of.Value<System::Int32>(integer)
	)
	{
	}
	
	public Bytes(Scalar::Any<System::Int32> integer) : base
	(
		new BytesFromSystem(
			new Result<System::Byte>(
				() => BitConverter.GetBytes(integer.Value)))
	)
	{
	}
}