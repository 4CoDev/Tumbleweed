using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace Tumbleweed.Mathematics.Vector.Spatial.Real.With.Coordinate.Definition;

public sealed class Uniform : Envelope<Any>
{
	public Uniform(Any coordinate) : base
	(
		new Unique(
			coordinate,
			coordinate,
			coordinate)
	)
	{
	}
}