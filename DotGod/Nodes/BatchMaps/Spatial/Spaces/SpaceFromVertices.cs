using Tumbleweed.Geometry.Spatial.Vertices;
using Tumbleweed.Geometry.Spatial.Vertices.Comparison;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

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