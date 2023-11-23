using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.Coordinate.Z.Actual;

namespace Tumbleweed.Mathematics.Vector.Spatial.Real.Coordinate.Z.Value;

public sealed class One : Envelope
{
	public One(Any<Any> point) : base
	(
		new Mathematics.Number.Real.Property.Value(
			new One<Any>(point))
	)
	{
	}
}