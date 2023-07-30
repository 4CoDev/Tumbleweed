using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex.FromArrayMesh.
	FromSurface;

public sealed class VerticesWithIndices
	: Tumbleweed.Enumerable.Envelope<IVertex>
{
	public VerticesWithIndices
	(
		Any<ArrayMesh> mesh,
		Any<Int32> surface,
		IEnumerable<Int32> indices
	) : base
	(
		new Selected<Int32, IVertex>(
			indices,
			index => new VertexWithIndex(mesh, surface, index))
	)
	{
	}
}