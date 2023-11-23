using Tumbleweed.Mathematics.Comparison.Vector.Spatial.Real;
using Multiple = Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.Member.Translation.Multiple;
using One = Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.With.Translation.One;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.Comparison;

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