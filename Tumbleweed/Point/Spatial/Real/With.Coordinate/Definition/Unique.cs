using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Point.Spatial.Real.With.Coordinate.Definition;

public sealed class Unique : Point::Generic.Envelope<Real::Any>
{
	public Unique
	(
		Real::Any x,
		Real::Any y,
		Real::Any z
	) : base
	(
		new Point::Generic.With.Coordinate.Definition.Unique
			<Real::Any>
			(x, y, z)
	)
	{
	}
}