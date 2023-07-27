using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Geometry.Spatial.Vertex;

public interface Any
{
	Point::Any<Real::Any> Translation { get; }
}