using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Arithmetics.
	Rounding.Nearest.As;

public sealed class Real : Scalar::Envelope<System::Single>
{
	public Real(System::Single single) : base
	(
		new Scalar::Of.Value<System::Single>(single)
	)
	{
	}
	
	public Real(Scalar::Any<System::Single> single) : base
	(
		new Scalar::Function.Result<System::Single>(
			() => MathF.Round(single.Value))
	)
	{
	}
}