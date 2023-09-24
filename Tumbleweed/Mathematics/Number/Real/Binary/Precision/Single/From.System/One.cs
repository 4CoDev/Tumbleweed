using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;
using Real = Tumbleweed.Mathematics.Number.Real;
using System = System;
using Single = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.From.System;

public sealed class One : Envelope
{
	public One(System::Single single) : this
	(
		new Value<System::Single>(single)
	)
	{
	}

	public One(Any<System::Single> single) : base
	(
		new Real::With.Members(
			new Single.System.Mantissa.Integer(single),
			new Base.As.Integer(),
			new Single::Exponent.As.Integer(single))
	)
	{
	}
}