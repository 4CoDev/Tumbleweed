using Tumbleweed.Number.Natural;
using Tumbleweed.Number.Natural.From.System;

namespace Tumbleweed.Array.Dimension.Linear.System.Length;

public sealed class Tumbleweed<T> : Envelope
{
	public Tumbleweed(Tumbleweed.Scalar.Any<T[]> array) : base
	(
		new One(
			new System<T>(array))
	)
	{
	}
}