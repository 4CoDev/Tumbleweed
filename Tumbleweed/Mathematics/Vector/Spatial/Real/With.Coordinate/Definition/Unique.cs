using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.With.Coordinate.Definition;

namespace Tumbleweed.Mathematics.Vector.Spatial.Real.With.Coordinate.Definition;

public sealed class Unique : Envelope<Any>
{
	public Unique
	(
		Any x,
		Any y,
		Any z
	) : base
	(
		new Unique
			<Any>
			(x, y, z)
	)
	{
	}
}