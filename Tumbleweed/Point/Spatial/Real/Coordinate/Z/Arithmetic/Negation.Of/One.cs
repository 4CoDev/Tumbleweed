using Tumbleweed.Point.Spatial.Generic;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Z.Arithmetic.Negation.Of;

public sealed class One : Number.Real.Envelope
{
	public One(Any<Number.Real.Any> point) : base
	(
		new Number.Real.Arithmetic.Negation.Of.One(
			new Coordinate.Z.Value.One(point)))
	{
	}
}