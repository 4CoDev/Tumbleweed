using DotGod.Geometry.Spatial.Graphical.Vertices.FromArrayMesh.FromSurface;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Polygons.Triangles.FromGodot.FromSurface;

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