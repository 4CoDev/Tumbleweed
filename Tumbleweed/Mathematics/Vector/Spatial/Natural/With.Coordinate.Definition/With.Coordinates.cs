using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.With.Coordinate.Definition;

namespace Tumbleweed.Mathematics.Vector.Spatial.Natural.With.Coordinate.Definition;

public sealed class Coordinates : Envelope<Any>
{
	public Coordinates
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