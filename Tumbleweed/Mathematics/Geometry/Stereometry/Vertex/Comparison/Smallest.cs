using Tumbleweed.Point.Spatial.Real.Comparison;
using Multiple = Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.Member.Translation.Multiple;
using One = Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.With.Translation.One;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.Comparison;

public sealed class Smallest : Envelope
{
	public Smallest
	(
		params Any[] vertices
	) : this
	(
		new List<Any>(vertices)
	)
	{
	}
	
	public Smallest
	(
		IEnumerable<Any> vertices
	) : this
	(
		new List<Any>(vertices)
	)
	{
	}
	
	public Smallest
	(
		ICollection<Any> vertices
	) : base
	(
		new One(
			new SmallestOfPoints(
				new Multiple(vertices)))
	)
	{
	}
}