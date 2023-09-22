using Tumbleweed.Geometry.Stereometry.Vertex.Comparison;

namespace Tumbleweed.Geometry.Stereometry.Vertex.Enumerable.Aabb;

public sealed class One : Shape.Parametric.Aabb.Envelope
{
	public One(IEnumerable<Any> vertices) : this
	(
		new List<Any>(vertices)
	)
	{
	}
	
	public One(ICollection<Any> vertices) : base
	(
		new Shape.Parametric.Aabb.With.Points.One(
			new Member.Translation.One(new Smallest(vertices)),
			new Member.Translation.One(new Largest(vertices)))
	)
	{
	}
}