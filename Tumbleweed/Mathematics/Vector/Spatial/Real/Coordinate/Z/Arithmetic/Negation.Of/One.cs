using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace Tumbleweed.Mathematics.Vector.Spatial.Real.Coordinate.Z.Arithmetic.Negation.Of;

public sealed class One : Envelope
{
	public One(Any<Any> point) : base
	(
		new Mathematics.Arithmetic.Numerical.Real.Negation.Of.One(
			new Coordinate.Z.Value.One(point)))
	{
	}
}