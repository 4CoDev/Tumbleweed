using Tumbleweed.Number.Natural;
using Tumbleweed.Number.Natural.From.System;
using Tumbleweed.Number.Natural.Function;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Comparison;
using Tumbleweed.Number.Real.Comparison.Is.Greater.Than;
using Tumbleweed.Number.Real.Comparison.Is.Greater.Than.Number;
using Any = Tumbleweed.Number.Real.Any;
using Envelope = Tumbleweed.Number.Natural.Envelope;
using One = Tumbleweed.Number.Natural.From.System.One;

namespace DotGod._Node.Batch.Index;

public sealed class IndexFromFractional : Envelope
{
	public IndexFromFractional(Any real) : base
	(
		new Result(
			() => Function(real))
			
	)
	{
	}

	private static Tumbleweed.Number.Natural.Any Function(Any real)
	{
		if (new Zero(real).State)
			return new One(0);
		return new One(1);
	}
}