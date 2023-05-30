using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

public sealed class TransformedVertices : EnumerableEnvelope<IVertex>
{
	public TransformedVertices
	(
		IEnumerable<IVertex> vertices,
		IScalar<Transform3D> transform
	) : base
	(
		new SelectedByExpression<IVertex>(
			vertices,
			vertex => new TransformedVertex(vertex, transform))
	)
	{
	}
}
