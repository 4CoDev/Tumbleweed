using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.From.Integer;

public sealed class One : Envelope<System::Single>
{
	public One(System::Int32 integer) : this
	(
		new Value<System::Int32>(integer)
	)
	{
	}

	public One(Any<System::Int32> integer) : base
	(
		new Actual<System::Single>(
			() => integer.Value)
	)
	{
	}
}