using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Number.Natural;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Natural.With.Coordinate.Definition;

public sealed class Coordinates : Envelope<Any>
{
	public Coordinates
	(
		Any x,
		Any y,
		Any z
	) : base
	(
		new Unique
			<Any>
			(x, y, z)
	)
	{
	}
}