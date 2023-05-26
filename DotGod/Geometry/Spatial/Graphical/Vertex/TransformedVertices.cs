using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Vertex;

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
