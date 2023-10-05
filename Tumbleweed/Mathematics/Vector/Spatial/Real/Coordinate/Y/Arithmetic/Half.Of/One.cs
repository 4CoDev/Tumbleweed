using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace Tumbleweed.Mathematics.Vector.Spatial.Real.Coordinate.Y.Arithmetic.Half.Of;

public sealed class One : Envelope
{
	public One
	(
		Any<Any> point
	) : base
	(
		new Mathematics.Arithmetic.Numerical.Real.Half.Of.One(
			new Value.One(point))
	)
	{
	}
}