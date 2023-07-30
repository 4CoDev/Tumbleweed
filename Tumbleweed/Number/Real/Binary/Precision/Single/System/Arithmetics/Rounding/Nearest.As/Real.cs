using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Arithmetics.
	Rounding.Nearest.As;

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