using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Number.Integer.System.Medium.Is.Positive;

public sealed class Statement : Scalar::Envelope<System::Int32>
{
	public Statement(System::Int32 integer) : this
	(
		new Scalar::Of.Value<System::Int32>(integer)
	)
	{
	}
	
	public Statement(Scalar::Any<System::Int32> integer) : base
	(
		new Scalar::Function.Result<System::Int32>(
			() => Function(integer))
	)
	{
	}

	private static Int32 Function(Scalar::Any<System::Int32> integer)
	{
		if (integer.Value >= 0) return integer.Value;
		throw new InvalidOperationException("Value is negative.");
	}
}