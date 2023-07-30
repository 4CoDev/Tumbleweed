using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Real = Tumbleweed.Number.Real;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Single = Tumbleweed.Number.Real.Binary.Precision.Single.System;
using Binary = Tumbleweed.Number.Real.Binary;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.From.System;

public sealed class One : Real::Envelope
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
			new Single::Mantissa.As.Integer(single),
			new Binary::Base.As.Integer(),
			new Single::Exponent.As.Integer(single))
	)
	{
	}
}