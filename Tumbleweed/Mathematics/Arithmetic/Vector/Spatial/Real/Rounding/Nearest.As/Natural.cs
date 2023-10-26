using Vector = Tumbleweed.Mathematics.Vector.Spatial;
using Number =  Tumbleweed.Mathematics.Number;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Real.With.Coordinate.Definition;
using One = Tumbleweed.Mathematics.Vector.Spatial.Real.Coordinate.Y.Value.One;

namespace Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Rounding.Nearest.As;

public sealed class Natural : Vector::Generic.Envelope<Number::Natural.Any>
{
	public Natural
	(
		Vector::Generic.Any<Number::Real.Any> point
	) : base
	(
		new Vector::Real.As.Natural.One(
			new Real(point)
		)
	)
	{
	}
}