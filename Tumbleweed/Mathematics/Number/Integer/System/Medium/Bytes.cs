using Tumbleweed.Byte.FromSystem;
using Tumbleweed.Enumerable.Function;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;
using System = System;

namespace Tumbleweed.Mathematics.Number.Integer.System.Medium;

public sealed class Bytes : Enumerable.Envelope<IEnumerable<Boolean.Any>>
{
	public Bytes(System::Int32 integer) : this
	(
		new Value<System::Int32>(integer)
	)
	{
	}
	
	public Bytes(Any<System::Int32> integer) : base
	(
		new BytesFromSystem(
			new Result<System::Byte>(
				() => BitConverter.GetBytes(integer.Value)))
	)
	{
	}
}