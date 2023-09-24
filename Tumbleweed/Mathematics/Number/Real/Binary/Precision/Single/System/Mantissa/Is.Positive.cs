using Tumbleweed.Mathematics.Boolean.From.Enumerable;
using Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Boolean = Tumbleweed.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Single = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Mantissa.Is;

public sealed class Positive : Boolean.Envelope
{
	public Positive(System::Single single) : this
	(
		new Value<System::Single>(single)
	)
	{
	}
	
	public Positive(Any<System::Single> single) : base
	(
		new Last(
			new Bits(single))
	)
	{
	}
}