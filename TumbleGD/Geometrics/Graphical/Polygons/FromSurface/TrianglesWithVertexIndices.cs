using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces.FromArrayMesh.FromSurface;
using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Polygons.
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