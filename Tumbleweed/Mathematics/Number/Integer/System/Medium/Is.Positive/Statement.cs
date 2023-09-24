using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.With;
using System = System;

namespace Tumbleweed.Mathematics.Number.Integer.System.Medium.Is.Positive;

public sealed class Statement : Envelope<System::Int32>
{
	public Statement(System::Int32 integer) : this
	(
		new Value<System::Int32>(integer)
	)
	{
	}
	
	public Statement(Any<System::Int32> integer) : base
	(
		new Actual<System::Int32>(
			() => Function(integer))
	)
	{
	}

	private static Int32 Function(Any<System::Int32> integer)
	{
		if (integer.Value >= 0) return integer.Value;
		throw new InvalidOperationException("Value is negative.");
	}
}