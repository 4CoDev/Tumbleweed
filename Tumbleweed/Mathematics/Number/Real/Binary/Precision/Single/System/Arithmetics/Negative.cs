using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;
using Tumbleweed.Property.Output.With;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Arithmetics;

public sealed class Negative : Envelope<System::Single>
{
	public Negative(System::Single single) : base
	(
		new Value<System::Single>(-single)
	)
	{
	}
	
	public Negative(Any<System::Single> single) : base
	(
		new Actual<System::Single>(
			() => -single.Value)
	)
	{
	}
}