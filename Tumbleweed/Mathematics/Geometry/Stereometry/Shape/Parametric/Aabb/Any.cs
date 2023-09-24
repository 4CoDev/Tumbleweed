using Point = Tumbleweed.Point.Spatial;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb;

public interface Any
{
	Point::Generic.Any<Mathematics.Number.Real.Any> A { get; }
	
	Point::Generic.Any<Mathematics.Number.Real.Any> B { get; }
}