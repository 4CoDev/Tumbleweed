using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.Coordinate.X.Actual;

namespace Tumbleweed.Mathematics.Vector.Spatial.Real.Coordinate.X.Value;

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