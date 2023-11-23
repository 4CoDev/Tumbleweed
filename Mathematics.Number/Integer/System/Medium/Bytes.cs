using Tumbleweed.Enumerable.Function;
using Tumbleweed.Information.Measurement.Byte.From.System;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;
using System = System;

namespace Tumbleweed.Mathematics.Number.Integer.System.Medium;

public sealed class Bytes : Enumerable.Envelope<IEnumerable<Boolean.Any>>
{
	public Bytes(System::Int32 integer) : this
	(
		new One<System::Int32>(integer)
	)
	{
	}
	
	public Bytes(Any<System::Int32> integer) : base
	(
		new Multiple(
			new Result<System::Byte>(
				() => BitConverter.GetBytes(integer.Value)))
	)
	{
	}
}