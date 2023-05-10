using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Vertices;

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
