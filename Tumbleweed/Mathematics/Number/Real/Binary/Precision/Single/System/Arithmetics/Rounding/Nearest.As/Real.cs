using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;
using Tumbleweed.Property.Output.With;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Arithmetics.Rounding.Nearest.As;

public sealed class Real : Envelope<System::Single>
{
	public Real(System::Single single) : base
	(
		new Value<System::Single>(single)
	)
	{
	}
	
	public Real(Any<System::Single> single) : base
	(
		new Actual<System::Single>(
			() => MathF.Round(single.Value))
	)
	{
	}
}