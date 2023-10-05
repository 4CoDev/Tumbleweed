using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.Coordinate.Y.Actual;

namespace Tumbleweed.Mathematics.Vector.Spatial.Real.Coordinate.Y.Value;

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