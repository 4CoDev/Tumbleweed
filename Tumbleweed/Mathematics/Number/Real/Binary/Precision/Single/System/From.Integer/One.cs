using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;
using Tumbleweed.Property.Output.With.Value;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From.Integer;

public sealed class One : Envelope<System::Single>
{
	public One(System::Int32 integer) : this
	(
		new One<System::Int32>(integer)
	)
	{
	}

	public One(Any<System::Int32> integer) : base
	(
		new Actual<System::Single>(
			() => integer.Value)
	)
	{
	}
}