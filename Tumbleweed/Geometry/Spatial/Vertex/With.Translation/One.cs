using Vertex = Tumbleweed.Geometry.Spatial.Vertex;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Geometry.Spatial.Vertex.With.Translation;

public sealed class One : Vertex::Any
{
	public One(Point::Any<Real::Any> translation) =>
		Translation = translation;

	public Point::Any<Real::Any> Translation { get; }
}