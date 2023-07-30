using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Arithmetics;

public sealed class Negative : Envelope<System::Single>
{
	public Negative(System::Single single) : base
	(
		new Value<System::Single>(-single)
	)
	{
	}
	
	public Negative(Any<System::Single> single) : base
	(
		new Actual<System::Single>(
			() => -single.Value)
	)
	{
	}
}