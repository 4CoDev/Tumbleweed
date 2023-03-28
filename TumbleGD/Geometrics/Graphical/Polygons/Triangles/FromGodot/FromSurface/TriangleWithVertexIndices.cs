using Godot;
using TumbleGD.Geometrics.Graphical.Vertices.FromArrayMesh.FromSurface;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Polygons.Triangles.FromGodot.FromSurface;

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