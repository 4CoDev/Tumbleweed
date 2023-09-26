using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.With.Coordinate.Definition;

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