using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Point.Spatial.Generic;
using Any = Tumbleweed.Mathematics.Number.Real.Any;
using One = Tumbleweed.Point.Spatial.Real.Coordinate.Z.Value.One;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Z.Comparison.Is.Equal.To.Specific;

public sealed class One : Envelope
{
	public One
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new Mathematics.Number.Real.Comparison.Is.Equals.To.Other.One(
			new Value.One(first),
			new Value.One(second))
	)
	{
	}
}