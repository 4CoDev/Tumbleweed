using Godot;
using TumbleGD.Geometrics.Graphical.Vertices;
using TumbleGD.Geometrics.Graphical.Vertices.FromArrayMesh.FromSurface;
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
		IScalar<Int32> surface,
		IEnumerable<IEnumerable<IScalar<Int32>>> triangles
	) : base
	(
		new SelectedByExpression<IEnumerable<IScalar<Int32>>, IEnumerable<IVertex>>(
			triangles,
			triangle =>
				new VerticesWithIndices(mesh, surface, triangle))
	)
	{
	}
}