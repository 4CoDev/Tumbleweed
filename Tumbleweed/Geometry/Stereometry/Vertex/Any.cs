using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Geometry.Stereometry.Vertex;

public interface Any
{
	Point::Generic.Any<Mathematics.Number.Real.Any> Translation { get; }
}