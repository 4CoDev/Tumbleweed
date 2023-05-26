using Tumbleweed._Enumerable;

namespace DotGod.Geometry.Spatial.Graphical.Vertex;

public sealed class LazyVertices : EnumerableEnvelope<IVertex>
{
	public LazyVertices(IEnumerable<IVertex> vertices) : base
	(
		new Tumbleweed._Enumerable.Lazy.SelectedByExpression<IVertex>(
			vertices,
			vertex => new LazyVertex(vertex))
	)
	{
	}
}