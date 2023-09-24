using Tumbleweed.Mathematics.Number.Real;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic.Half.Of;

public sealed class One : Point::Generic.Envelope<Any>
{
	public One
	(
		Point::Generic.Any<Any> whole
	) : base
	(
		new Point::Real.With.Coordinate.Definition.Unique(
			new Point::Real.Coordinate.X.Arithmetic.Half.Of.One(whole),
			new Point::Real.Coordinate.Y.Arithmetic.Half.Of.One(whole),
			new Point::Real.Coordinate.Z.Arithmetic.Half.Of.One(whole))
	)
	{
	}
}