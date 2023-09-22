using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Geometry.Stereometry.Vertex;

public interface Any
{
	Point::Generic.Any<Real::Any> Translation { get; }
}