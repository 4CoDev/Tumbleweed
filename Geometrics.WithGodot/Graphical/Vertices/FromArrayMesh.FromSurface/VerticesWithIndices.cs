using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Geometrics.Graphical.Vertices;
using Tumbleweed.Scalars;

namespace Tumbleweed.Geometrics.WithGodot.Graphical.Vertices.FromArrayMesh.
	FromSurface;

public sealed class VerticesWithIndices
	: EnumerableEnvelope<IVertex>
{
	public VerticesWithIndices
	(
		IScalar<ArrayMesh> mesh,
		IScalar<int> surface,
		IEnumerable<IScalar<int>> indices
	) : base
	(
		new SelectedByExpression<IScalar<int>, IVertex>(
			indices,
			index => new VertexWithIndex(mesh, surface, index))
	)
	{
	}
}