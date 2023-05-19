using Tumbleweed.Points.Spatial.Real.Comparison;

namespace Tumbleweed.Geometry.Spatial.Vertices.Comparison;

public sealed class SmallestOfVertices : VertexEnvelope
{
	public SmallestOfVertices
	(
		params IVertex[] vertices
	) : this
	(
		new List<IVertex>(vertices)
	)
	{
	}
	
	public SmallestOfVertices
	(
		IEnumerable<IVertex> vertices
	) : this
	(
		new List<IVertex>(vertices)
	)
	{
	}
	
	public SmallestOfVertices
	(
		ICollection<IVertex> vertices
	) : base
	(
		new VertexWithTranslation(
			new SmallestOfPoints(
				new TranslationsOfVertices(vertices)))
	)
	{
	}
}