using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Any = Tumbleweed.Mathematics.Number.Real.Any;

namespace Tumbleweed.Mathematics.Vector.Spatial.Real.Coordinate.X.Comparison.Is.Greater.Than.Just.Specific;

public sealed class One : Envelope
{
	public One
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new Mathematics.Comparison.Numerical.Real.Is.Greater.Than.Strictly.Specific.One(
			new Value.One(first),
			new Value.One(second))
	)
	{
	}
}