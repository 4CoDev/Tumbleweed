using Tumbleweed.Mathematics.Number.Real.From.Natural.As;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Natural.Coordinate;
using Tumbleweed.Mathematics.Vector.Spatial.Real.With.Coordinate.Definition;
using Any = Tumbleweed.Mathematics.Number.Real.Any;

namespace Tumbleweed.Mathematics.Vector.Spatial.Natural.As.Real;

public sealed class One : Envelope<Any>
{
	public One(Any<Mathematics.Number.Natural.Any> natural) : base
	(
		new Unique(
			new Positive(new X(natural)),
			new Positive(new Y(natural)),
			new Positive(new Z(natural)))
	)
	{
	}
}