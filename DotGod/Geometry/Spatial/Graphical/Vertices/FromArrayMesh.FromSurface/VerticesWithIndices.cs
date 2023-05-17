using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Vertices.FromArrayMesh.
	FromSurface;

public sealed class VerticesWithIndices
	: EnumerableEnvelope<IVertex>
{
	public VerticesWithIndices
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface,
		IEnumerable<Int32> indices
	) : base
	(
		new SelectedByExpression<Int32, IVertex>(
			indices,
			index => new VertexWithIndex(mesh, surface, index))
	)
	{
	}
}