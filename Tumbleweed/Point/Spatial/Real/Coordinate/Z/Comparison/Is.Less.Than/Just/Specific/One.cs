using Tumbleweed.Point.Spatial.Generic;
using Any = Tumbleweed.Number.Real.Any;
using One = Tumbleweed.Point.Spatial.Real.Coordinate.Z.Value.One;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Z.Comparison.Is.Less.Than.Just.Specific;

public sealed class One : Boolean.Envelope
{
	public One
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new Number.Real.Comparison.Is.Less.Than.Other.One(
			new Value.One(first),
			new Value.One(second))
	)
	{
	}
}