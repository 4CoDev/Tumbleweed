using Tumbleweed.Point.Spatial.Real.Comparison;
using Multiple = Tumbleweed.Geometry.Stereometry.Vertex.Member.Translation.Multiple;
using One = Tumbleweed.Geometry.Stereometry.Vertex.With.Translation.One;

namespace Tumbleweed.Geometry.Stereometry.Vertex.Comparison;

public sealed class Largest : Envelope
{
	public Largest
	(
		params Any[] vertices
	) : this
	(
		new List<Any>(vertices)
	)
	{
	}
	
	public Largest
	(
		IEnumerable<Any> vertices
	) : this
	(
		new List<Any>(vertices)
	)
	{
	}
	
	public Largest
	(
		ICollection<Any> vertices
	) : base
	(
		new One(
			new LargestOfPoints(
				new Multiple(vertices)))
	)
	{
	}
}