using Natural = Tumbleweed.Number.Natural;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Array.Dimension.Linear.Index.From.MultiDimensional.Tumbleweed.As;

public sealed class Tumbleweed : Natural::Envelope
{
	public Tumbleweed
	(
		SCG::IEnumerable<Natural::Any> indices,
		SCG::IEnumerable<Natural::Any> dimensions
	) : base
	(
		new Natural::From.System.One(
			new System(indices, dimensions))
	)
	{
	}
}