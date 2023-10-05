using Tumbleweed.Mathematics.Number.Integer;
using Tumbleweed.Mathematics.Number.Integer.From.System;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace Tumbleweed.Mathematics.Arithmetic.Numerical.Integer;

public sealed class Logarithm : Envelope
{
	public Logarithm(Any argument) : this
	(
		new One(10), argument
	)
	{
	}

	public Logarithm(Any @base, Any argument) : base
	(
		new One(
			new Actual<Int32>(
				() => (Int32)Math.Log(
					new Number.Integer.System.Medium.From.Tumbleweed.One(@base).Value,
					new Number.Integer.System.Medium.From.Tumbleweed.One(argument).Value)))
	)
	{
	}
}