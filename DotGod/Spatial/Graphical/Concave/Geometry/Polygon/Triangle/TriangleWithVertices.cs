using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

using Tumbleweed.Enumerable.With.Length.Statement;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon.Triangle;

public sealed class TriangleWithVertices : PolygonEnvelope
{
	public TriangleWithVertices(IEnumerable<IVertex> vertices) : base
	(
		new PolygonWithVertices(
			new System<IVertex>(vertices, 3))
	)
	{
	}
}