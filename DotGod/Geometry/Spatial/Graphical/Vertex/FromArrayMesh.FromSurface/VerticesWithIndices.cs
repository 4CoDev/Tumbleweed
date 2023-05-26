using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Vertex.FromArrayMesh.
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