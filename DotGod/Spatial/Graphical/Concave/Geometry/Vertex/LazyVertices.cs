using Tumbleweed.Enumerable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

public sealed class LazyVertices : Envelope<IVertex>
{
	public LazyVertices(IEnumerable<IVertex> vertices) : base
	(
		new Tumbleweed.Enumerable.Lazy.Selected<IVertex>(
			vertices,
			vertex => new LazyVertex(vertex))
	)
	{
	}
}