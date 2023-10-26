using Scalar = Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Mantissa;

public sealed class Length : Scalar::Envelope<System::Int32>
{
	public Length() : base
	(
		new Scalar::With.Value<System::Int32>(23)
	)
	{
	}
}