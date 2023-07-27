using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.From.Integer;

public sealed class One : Scalar::Envelope<System::Single>
{
	public One(System::Int32 integer) : this
	(
		new Scalar::Of.Value<System::Int32>(integer)
	)
	{
	}

	public One(Scalar::Any<System::Int32> integer) : base
	(
		new Scalar::Function.Result<System::Single>(
			() => integer.Value)
	)
	{
	}
}