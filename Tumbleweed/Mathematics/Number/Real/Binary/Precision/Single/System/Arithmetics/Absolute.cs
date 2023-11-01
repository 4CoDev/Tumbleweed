using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;
using Tumbleweed.Property.Output.With;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Arithmetics;

public sealed class Absolute : Envelope<System::Single>
{
	public Absolute(System::Single single) : base
	(
		new Value<System::Single>(single)
	)
	{
	}
	
	public Absolute(Any<System::Single> single) : base
	(
		new Actual<System::Single>(
			() => Math.Abs(single.Value))
	)
	{
	}
}