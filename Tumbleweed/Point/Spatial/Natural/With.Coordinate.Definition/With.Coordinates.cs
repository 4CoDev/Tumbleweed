using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Generic.With.Coordinate.Definition;
using Natural = Tumbleweed.Number.Natural;

namespace Tumbleweed.Point.Spatial.Natural.With.Coordinate.Definition;

public sealed class Coordinates : Envelope<Natural::Any>
{
	public Coordinates
	(
		Natural::Any x,
		Natural::Any y,
		Natural::Any z
	) : base
	(
		new Unique
			<Natural::Any>
			(x, y, z)
	)
	{
	}
}