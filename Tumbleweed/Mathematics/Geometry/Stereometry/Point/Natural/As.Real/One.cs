using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Natural.Coordinate;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Number.Real.From.Natural.As;
using Any = Tumbleweed.Mathematics.Number.Real.Any;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Natural.As.Real;

public sealed class One : Envelope<Any>
{
	public One(Any<Mathematics.Number.Natural.Any> natural) : base
	(
		new Unique(
			new Positive(new X(natural)),
			new Positive(new Y(natural)),
			new Positive(new Z(natural)))
	)
	{
	}
}