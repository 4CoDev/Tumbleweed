using Tumbleweed.Geometry.Spatial.Vertex.Translation;
using Tumbleweed.Geometry.Spatial.Vertex.With.Translation;
using Tumbleweed.Point.Spatial.Real.Comparison;
using Multiple = Tumbleweed.Geometry.Spatial.Vertex.Translation.Multiple;
using One = Tumbleweed.Geometry.Spatial.Vertex.With.Translation.One;

namespace Tumbleweed.Geometry.Spatial.Vertex.Comparison;

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