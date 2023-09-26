using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Natural.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Number.Natural;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.As.Natural;

public sealed class One : Envelope<Any>
{
	public One(Any<Mathematics.Number.Real.Any> real) : base
	(
		new Coordinates(
			new Number.Natural.From.Real(new Geometry.Stereometry.Point.Real.Coordinate.X.Value.One(real)),
			new Number.Natural.From.Real(new Geometry.Stereometry.Point.Real.Coordinate.Y.Value.One(real)),
			new Number.Natural.From.Real(new Geometry.Stereometry.Point.Real.Coordinate.Z.Value.One(real)))
	)
	{
	}
}