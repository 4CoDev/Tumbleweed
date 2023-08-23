using Tumbleweed.Geometry.Spatial.Vertex.With.Translation;
using Tumbleweed.Point.Spatial.Implementation.Real.Comparison;
using Multiple = Tumbleweed.Geometry.Spatial.Vertex.Member.Translation.Multiple;
using One = Tumbleweed.Geometry.Spatial.Vertex.With.Translation.One;

namespace Tumbleweed.Geometry.Spatial.Vertex.Comparison;

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