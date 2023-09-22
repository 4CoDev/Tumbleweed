using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb;

public interface Any
{
	Point::Generic.Any<Real::Any> A { get; }
	
	Point::Generic.Any<Real::Any> B { get; }
}