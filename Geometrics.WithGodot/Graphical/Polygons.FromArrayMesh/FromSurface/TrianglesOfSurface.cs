using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Geometrics.Graphical.Vertices;
using Tumbleweed.Geometrics.WithGodot.Graphical.Vertices.Indices.FromArrayMesh.FromSurface;
using Tumbleweed.Scalars;

namespace Tumbleweed.Geometrics.WithGodot.Graphical.Polygons.FromArrayMesh.
	FromSurface;

public sealed class TrianglesOfSurface
	: EnumerableEnvelope<IEnumerable<IVertex>>
{
	public TrianglesOfSurface
	(
		IScalar<ArrayMesh> mesh,
		IScalar<int> surface
	) : base
	(
		new TrianglesWithVertexIndices(
			mesh,
			surface,
			new VertexIndicesOfTriangles(mesh, surface))
	)
	{
	}
}