using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Number.Natural.Property;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.Coordinate.Z.Actual;

namespace Tumbleweed.Mathematics.Vector.Spatial.Natural.Coordinate;

public sealed class Z : Envelope
{
	public Z(Any<Any> point) : base
	(
		new Value(
			new One<Any>(point))
	)
	{
	}
}