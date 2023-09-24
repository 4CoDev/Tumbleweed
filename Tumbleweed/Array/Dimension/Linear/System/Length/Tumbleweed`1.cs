using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Number.Natural.From.System;
using Tumbleweed.Mathematics.Number.Natural;

namespace Tumbleweed.Array.Dimension.Linear.System.Length;

public sealed class Tumbleweed<T> : Envelope
{
	public Tumbleweed(Tumbleweed.Scalar.Immutable.Any<T[]> array) : base
	(
		new One(
			new System<T>(array))
	)
	{
	}
}