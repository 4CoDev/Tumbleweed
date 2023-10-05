using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Real.With.Coordinate.Definition;
using One = Tumbleweed.Mathematics.Vector.Spatial.Real.Coordinate.Y.Value.One;

namespace Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Rounding.Nearest.As;

public sealed class Real : Envelope<Any>
{
	public Real(Any<Any> point) : base
	(
		new Unique(
			new Mathematics.Arithmetic.Numerical.Real.Rounding.Nearest.As.Real(new Mathematics.Vector.Spatial.Real.Coordinate.X.Value.One(point)),
			new Mathematics.Arithmetic.Numerical.Real.Rounding.Nearest.As.Real(new One(point)),
			new Mathematics.Arithmetic.Numerical.Real.Rounding.Nearest.As.Real(new Mathematics.Vector.Spatial.Real.Coordinate.Z.Value.One(point)))
	)
	{
	}
}