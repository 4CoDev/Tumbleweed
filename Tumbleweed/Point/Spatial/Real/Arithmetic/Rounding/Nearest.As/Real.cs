using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Real.Coordinate;
using Tumbleweed.Point.Spatial.Real.Coordinate.X;
using Tumbleweed.Point.Spatial.Real.Coordinate.Y;
using Tumbleweed.Point.Spatial.Real.Coordinate.Z;
using Tumbleweed.Point.Spatial.Real.With.Coordinate.Definition;
using One = Tumbleweed.Point.Spatial.Real.Coordinate.Y.Value.One;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic.Rounding.Nearest.As;

public sealed class Real : Envelope<Any>
{
	public Real(Any<Any> point) : base
	(
		new Unique(
			new Number.Real.Arithmetic.Rounding.Nearest.As.Real(new Coordinate.X.Value.One(point)),
			new Number.Real.Arithmetic.Rounding.Nearest.As.Real(new One(point)),
			new Number.Real.Arithmetic.Rounding.Nearest.As.Real(new Coordinate.Z.Value.One(point)))
	)
	{
	}
}