using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.Coordinate.Z.Actual;
using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Coordinate.Z.Value;

public sealed class One : Envelope
{
	public One(Any<Any> point) : base
	(
		new Mathematics.Number.Real.Scalar.Value(
			new One<Any>(point))
	)
	{
	}
}