using Tumbleweed.Enumerables;
using Tumbleweed.Points.Spatial;
using IRealNumber = Tumbleweed.Numbers.Real.IReal;

namespace Tumbleweed.Geometry.Spatial.Vertices;

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