using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices.FromArrayMesh.
	FromSurface;

public sealed class VerticesWithIndices
	: EnumerableEnvelope<IVertex>
{
	public VerticesWithIndices
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface,
		IEnumerable<IScalar<Int32>> indices
	) : base
	(
		new SelectedByExpression<IScalar<Int32>, IVertex>(
			indices,
			index => new VertexWithIndex(mesh, surface, index))
	)
	{
	}
}