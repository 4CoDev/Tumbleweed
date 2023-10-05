using Tumbleweed.Enumerable;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Vertex.Lazy;

public sealed class Enumerable : Envelope<Any>
{
	public Enumerable(IEnumerable<Any> vertices) : base
	(
		new Tumbleweed.Enumerable.Lazy.Selected<Any>(
			vertices,
			vertex => new One(vertex))
	)
	{
	}
}