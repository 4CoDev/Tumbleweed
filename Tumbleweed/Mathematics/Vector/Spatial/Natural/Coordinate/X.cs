using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Number.Natural.Scalar;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.Coordinate.X.Actual;

namespace Tumbleweed.Mathematics.Vector.Spatial.Natural.Coordinate;

public sealed class X : Envelope
{
	public X(Any<Any> point) : base
	(
		new Value(
			new One<Any>(point))
	)
	{
	}
}