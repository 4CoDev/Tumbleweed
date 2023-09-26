using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Number.Real;
using One = Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Coordinate.Y.Value.One;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Rounding.Nearest.As;

public sealed class Real : Envelope<Any>
{
	public Real(Any<Any> point) : base
	(
		new Unique(
			new Mathematics.Arithmetic.Real.Rounding.Nearest.As.Real(new Coordinate.X.Value.One(point)),
			new Mathematics.Arithmetic.Real.Rounding.Nearest.As.Real(new One(point)),
			new Mathematics.Arithmetic.Real.Rounding.Nearest.As.Real(new Coordinate.Z.Value.One(point)))
	)
	{
	}
}