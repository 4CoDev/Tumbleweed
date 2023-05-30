using Tumbleweed._Enumerable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

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