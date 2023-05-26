using DotGod._Node.BatchMap.Spatial.Spaces;
using Tumbleweed.Geometry.Spatial.Vertex;
using Tumbleweed.Geometry.Spatial.Vertex.Comparison;

namespace DotGod.Geometry.Spatial.Space;

public sealed class SpaceFromVertices : SpaceEnvelope
{
	public SpaceFromVertices(IEnumerable<IVertex> vertices) : this
	(
		new List<IVertex>(vertices)
	)
	{
	}
	
	public SpaceFromVertices(ICollection<IVertex> vertices) : base
	(
		new SpaceWithPoints(
			new TranslationOfVertex(new SmallestOfVertices(vertices)),
			new TranslationOfVertex(new LargestOfVertices(vertices)))
	)
	{
	}
}