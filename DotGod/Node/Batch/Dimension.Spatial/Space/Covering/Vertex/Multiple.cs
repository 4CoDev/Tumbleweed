using Tumbleweed.Geometry.Spatial.Vertex.Comparison;
using One = DotGod.Node.Batch.Dimension.Spatial.Space.With.Points.One;

namespace DotGod.Node.Batch.Dimension.Spatial.Space.Covering.Vertex;

public sealed class Multiple : Envelope
{
	public Multiple(IEnumerable<Tumbleweed.Geometry.Spatial.Vertex.Any> vertices) : this
	(
		new List<Tumbleweed.Geometry.Spatial.Vertex.Any>(vertices)
	)
	{
	}
	
	public Multiple(ICollection<Tumbleweed.Geometry.Spatial.Vertex.Any> vertices) : base
	(
		new One(
			new Tumbleweed.Geometry.Spatial.Vertex.Translation.One(new Smallest(vertices)),
			new Tumbleweed.Geometry.Spatial.Vertex.Translation.One(new Largest(vertices)))
	)
	{
	}
}