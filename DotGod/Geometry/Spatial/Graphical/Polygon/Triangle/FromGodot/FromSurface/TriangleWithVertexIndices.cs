using DotGod.Geometry.Spatial.Graphical.Vertex.FromArrayMesh.FromSurface;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Polygon.Triangle.FromGodot.FromSurface;

public sealed class TriangleWithVertexIndices : PolygonEnvelope
{
	public TriangleWithVertexIndices
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface,
		IEnumerable<Int32> indices) : base
	(
		new PolygonWithVertices(
			new VerticesWithIndices(mesh, surface, indices))
	)
	{
	}
}