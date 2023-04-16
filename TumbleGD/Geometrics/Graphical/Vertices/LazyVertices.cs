using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.Lazy;

namespace TumbleGD.Geometrics.Graphical.Vertices;

public sealed class LazyVertices : EnumerableEnvelope<IVertex>
{
	public LazyVertices(IEnumerable<IVertex> vertices) : base
	(
		new Tumbleweed.Enumerables.Lazy.SelectedByExpression<IVertex>(
			vertices,
			vertex => new LazyVertex(vertex))
	)
	{
	}
}