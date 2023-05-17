using DotGod.Geometry.Spatial.Graphical.Vertices;
using Tumbleweed.Enumerables.FromSystem;

namespace DotGod.Geometry.Spatial.Graphical.Polygons.Triangles;

public sealed class TriangleWithVertices : PolygonEnvelope
{
	public TriangleWithVertices(IEnumerable<IVertex> vertices) : base
	(
		new PolygonWithVertices(
			new EnumerableWithSize<IVertex>(vertices, 3))
	)
	{
	}
}