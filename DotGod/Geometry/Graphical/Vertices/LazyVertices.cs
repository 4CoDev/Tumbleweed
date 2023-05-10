using Tumbleweed.Enumerables;

namespace DotGod.Geometry.Graphical.Vertices;

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