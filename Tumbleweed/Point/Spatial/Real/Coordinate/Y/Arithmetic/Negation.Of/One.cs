using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Point.Spatial.Generic;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Y.Arithmetic.Negation.Of;

public sealed class One : Envelope
{
	public One(Any<Any> point) : base
	(
		new Mathematics.Arithmetic.Real.Negation.Of.One(
			new Coordinate.Y.Value.One(point)))
	{
	}
}