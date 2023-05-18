using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Geometry.Spatial.Vertices;

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