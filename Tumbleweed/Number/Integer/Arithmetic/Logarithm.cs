using Tumbleweed.Number.Integer.From.System;
using TW = Tumbleweed;

namespace Tumbleweed.Number.Integer.Arithmetic;

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
			new TW.Scalar.Function.Result<Int32>(
				() => (Int32)Math.Log(
					new System.Medium.From.Tumbleweed.One(@base).Value,
					new System.Medium.From.Tumbleweed.One(argument).Value)))
	)
	{
	}
}