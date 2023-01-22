using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Geometrics.Graphical.Vertices;
using Tumbleweed.Geometrics.WithGodot.Graphical.Vertices.FromArrayMesh.FromSurface;
using Tumbleweed.Geometrics.WithGodot.Graphical.Vertices.Indices.FromArrayMesh.FromSurface;
using Tumbleweed.Scalars;

namespace Tumbleweed.Geometrics.WithGodot.Graphical.Polygons.FromArrayMesh.FromSurface;

public sealed class TriangleWithIndex : EnumerableEnvelope<IVertex>
{
	public TriangleWithIndex
	(
		IScalar<ArrayMesh> mesh,
		IScalar<int> surface,
		IScalar<int> triangle
	) : base
	(
		new VerticesWithIndices(
			mesh,
			surface,
			new VertexIndicesOfTriangle(mesh, surface, triangle))
	)
	{
	}
}