using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.From.Natural;

public sealed class One : Scalar::Envelope<System::Single>
{
	public One(System::UInt32 integer) : this
	(
		new Scalar::Of.Value<System::UInt32>(integer)
	)
	{
	}
	
	public One(Scalar::Any<System::UInt32> integer) : base
	(
		new Scalar::Function.Result<System::Single>(
			() => integer.Value)
	)
	{
	}
}