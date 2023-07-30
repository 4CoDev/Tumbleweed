using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Mantissa;

public sealed class Length : Envelope<System::Int32>
{
	public Length() : base
	(
		new Value<System::Int32>(23)
	)
	{
	}
}