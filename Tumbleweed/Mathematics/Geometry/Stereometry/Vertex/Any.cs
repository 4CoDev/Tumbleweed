using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Vertex;

public interface Any
{
	Point::Generic.Any<Real::Any> Translation { get; }
}