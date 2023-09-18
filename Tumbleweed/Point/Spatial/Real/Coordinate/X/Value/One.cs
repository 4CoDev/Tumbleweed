using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Generic.Coordinate.X.Actual;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.X.Value;

public sealed class One : Envelope
{
	public One(Any<Any> point) : base
	(
		new Number.Real.Scalar.Value(
			new One<Any>(point))
	)
	{
	}
}