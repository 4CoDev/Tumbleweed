using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Point.Spatial.Generic;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.X.Arithmetic.Negation.Of;

public sealed class One : Envelope
{
	public One(Any<Any> point) : base
	(
		new Mathematics.Arithmetic.Real.Negation.Of.One(
			new Coordinate.X.Value.One(point)))
	{
	}
}