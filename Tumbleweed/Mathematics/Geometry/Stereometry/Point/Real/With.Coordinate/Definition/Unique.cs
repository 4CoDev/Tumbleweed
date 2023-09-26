using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.With.Coordinate.Definition;

public sealed class Unique : Envelope<Any>
{
	public Unique
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