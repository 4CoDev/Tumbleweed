using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Arithmetics;

public sealed class Absolute : Scalar::Envelope<System::Single>
{
	public Absolute(System::Single single) : base
	(
		new Scalar::Of.Value<System::Single>(single)
	)
	{
	}
	
	public Absolute(Scalar::Any<System::Single> single) : base
	(
		new Scalar::Function.Result<System::Single>(
			() => Math.Abs(single.Value))
	)
	{
	}
}