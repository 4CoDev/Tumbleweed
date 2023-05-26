using Tumbleweed._Enumerable;
using Tumbleweed.Point.Spatial;
using IRealNumber = Tumbleweed.Number.Real.IReal;

namespace Tumbleweed.Geometry.Spatial.Vertex;

public sealed class TranslationsOfVertices :
	EnumerableEnvelope<IPoint<IRealNumber>>
{
	public TranslationsOfVertices(IEnumerable<IVertex> vertices) : base
	(
		new SelectedByExpression<IVertex, IPoint<IRealNumber>>(
			vertices,
			vertex => vertex.Translation)
	)
	{
	}
}