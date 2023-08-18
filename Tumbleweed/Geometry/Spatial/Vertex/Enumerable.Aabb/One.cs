using Tumbleweed.Geometry.Spatial.Vertex.Comparison;
using One = Tumbleweed.Geometry.Spatial.Aabb.With.Points.One;

namespace Tumbleweed.Geometry.Spatial.Vertex.Enumerable.Aabb;

public sealed class One : Spatial.Aabb.Envelope
{
	public One(IEnumerable<Tumbleweed.Geometry.Spatial.Vertex.Any> vertices) : this
	(
		new List<Tumbleweed.Geometry.Spatial.Vertex.Any>(vertices)
	)
	{
	}
	
	public One(ICollection<Tumbleweed.Geometry.Spatial.Vertex.Any> vertices) : base
	(
		new Spatial.Aabb.With.Points.One(
			new Member.Translation.One(new Smallest(vertices)),
			new Member.Translation.One(new Largest(vertices)))
	)
	{
	}
}