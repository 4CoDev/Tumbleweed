using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Arithmetics;

public sealed class Negative : Scalar::Envelope<System::Single>
{
	public Negative(System::Single single) : base
	(
		new Scalar::Of.Value<System::Single>(-single)
	)
	{
	}
	
	public Negative(Scalar::Any<System::Single> single) : base
	(
		new Scalar::Function.Result<System::Single>(
			() => -single.Value)
	)
	{
	}
}