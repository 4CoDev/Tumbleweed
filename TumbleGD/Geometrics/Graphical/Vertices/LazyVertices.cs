using Tumbleweed.Enumerables;

namespace TumbleGD.Geometrics.Graphical.Vertices;

public sealed class LazyVertices : EnumerableEnvelope<IVertex>
{
	public LazyVertices(IEnumerable<IVertex> vertices) : base
	(
		new LazySelectedByExpression<IVertex>(
			vertices,
			vertex => new LazyVertex(vertex))
	)
	{
	}
}