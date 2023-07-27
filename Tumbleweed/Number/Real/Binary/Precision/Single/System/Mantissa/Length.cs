using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Mantissa;

public sealed class Length : Scalar::Envelope<System::Int32>
{
	public Length() : base
	(
		new Scalar::Of.Value<System::Int32>(23)
	)
	{
	}
}