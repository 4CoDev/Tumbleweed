using Tumbleweed.Geometry.Spatial.Vertex.Comparison;
using Tumbleweed.Geometry.Spatial.Vertex.Translation;

namespace DotGod.Node.Spatial.Batch.Space;

public sealed class SpaceFromVertices : SpaceEnvelope
{
	public SpaceFromVertices(IEnumerable<Tumbleweed.Geometry.Spatial.Vertex.Any> vertices) : this
	(
		new List<Tumbleweed.Geometry.Spatial.Vertex.Any>(vertices)
	)
	{
	}
	
	public SpaceFromVertices(ICollection<Tumbleweed.Geometry.Spatial.Vertex.Any> vertices) : base
	(
		new SpaceWithPoints(
			new One(new Smallest(vertices)),
			new One(new Largest(vertices)))
	)
	{
	}
}