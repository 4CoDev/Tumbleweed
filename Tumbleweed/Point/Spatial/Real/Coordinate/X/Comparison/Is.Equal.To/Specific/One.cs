using Tumbleweed.Point.Spatial.Generic;
using Any = Tumbleweed.Number.Real.Any;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.X.Comparison.Is.Equal.To.Specific;

public sealed class One : Boolean.Envelope
{
	public One
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new Number.Real.Comparison.Is.Equals.To.Other.One(
			new Value.One(first),
			new Value.One(second))
	)
	{
	}
}