using Tumbleweed._Enumerable;
using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;

namespace Tumbleweed.Spatial.Geometry.Vertex;

public sealed class VerticesWithTranslations : EnumerableEnvelope<IVertex>
{
	public VerticesWithTranslations
	(
		IEnumerable<IPoint<IReal>> translations
	) : base
	(
		new SelectedByExpression<IPoint<IReal>,IVertex>(
			translations,
			translation => new VertexWithTranslation(translation))
	)
	{
	}
}