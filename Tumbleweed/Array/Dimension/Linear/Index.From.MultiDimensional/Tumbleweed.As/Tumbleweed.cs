using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Number.Natural.From.System;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Array.Dimension.Linear.Index.From.MultiDimensional.Tumbleweed.As;

public sealed class Tumbleweed : Envelope
{
	public Tumbleweed
	(
		SCG::IEnumerable<Any> indices,
		SCG::IEnumerable<Any> dimensions
	) : base
	(
		new One(
			new System(indices, dimensions))
	)
	{
	}
}