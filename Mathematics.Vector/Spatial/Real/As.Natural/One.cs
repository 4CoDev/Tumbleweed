using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Natural.With.Coordinate.Definition;

namespace Tumbleweed.Mathematics.Vector.Spatial.Real.As.Natural;

public sealed class One : Envelope<Any>
{
	public One(Any<Mathematics.Number.Real.Any> real) : base
	(
		new Coordinates(
			new Number.Natural.From.Real(new Coordinate.X.Value.One(real)),
			new Number.Natural.From.Real(new Coordinate.Y.Value.One(real)),
			new Number.Natural.From.Real(new Coordinate.Z.Value.One(real)))
	)
	{
	}
}