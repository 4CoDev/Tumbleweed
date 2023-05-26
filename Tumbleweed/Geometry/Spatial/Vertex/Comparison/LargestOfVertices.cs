using Tumbleweed.Point.Spatial.Real.Comparison;

namespace Tumbleweed.Geometry.Spatial.Vertex.Comparison;

public sealed class LargestOfVertices : VertexEnvelope
{
	public LargestOfVertices
	(
		params IVertex[] vertices
	) : this
	(
		new List<IVertex>(vertices)
	)
	{
	}
	
	public LargestOfVertices
	(
		IEnumerable<IVertex> vertices
	) : this
	(
		new List<IVertex>(vertices)
	)
	{
	}
	
	public LargestOfVertices
	(
		ICollection<IVertex> vertices
	) : base
	(
		new VertexWithTranslation(
			new LargestOfPoints(
				new TranslationsOfVertices(vertices)))
	)
	{
	}
}