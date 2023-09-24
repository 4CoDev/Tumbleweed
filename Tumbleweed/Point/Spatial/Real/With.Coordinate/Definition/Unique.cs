using Tumbleweed.Mathematics.Number.Real;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Point.Spatial.Real.With.Coordinate.Definition;

public sealed class Unique : Point::Generic.Envelope<Any>
{
	public Unique
	(
		Any x,
		Any y,
		Any z
	) : base
	(
		new Point::Generic.With.Coordinate.Definition.Unique
			<Any>
			(x, y, z)
	)
	{
	}
}