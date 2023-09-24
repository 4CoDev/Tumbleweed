using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Generic.With.Coordinate.Definition;
using Natural = Tumbleweed.Mathematics.Number.Natural;

namespace Tumbleweed.Point.Spatial.Natural.With.Coordinate.Definition;

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