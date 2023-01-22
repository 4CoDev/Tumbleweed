using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Geometrics.Graphical.Vertices;
using Tumbleweed.Geometrics.WithGodot.Graphical.Vertices.FromArrayMesh.FromSurface;
using Tumbleweed.Scalars;

namespace Tumbleweed.Geometrics.WithGodot.Graphical.Polygons.FromArrayMesh.
	FromSurface;

public sealed class TrianglesWithVertexIndices
	: EnumerableEnvelope<IEnumerable<IVertex>>
{
	public TrianglesWithVertexIndices
	(
		IScalar<ArrayMesh> mesh,
		IScalar<int> surface,
		IEnumerable<IEnumerable<IScalar<int>>> triangles
	) : base
	(
		new SelectedByExpression<IEnumerable<IScalar<int>>, IEnumerable<IVertex>>(
			triangles,
			triangle =>
				new VerticesWithIndices(mesh, surface, triangle))
	)
	{
	}
}