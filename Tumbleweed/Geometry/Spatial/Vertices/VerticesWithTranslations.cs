using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Geometry.Spatial.Vertices;

public sealed class VerticesWithTranslations : EnumerableEnvelope<IVertex>
{
	public VerticesWithTranslations
	(
		IEnumerable<ISpatial<IReal>> translations
	) : base
	(
		new SelectedByExpression<ISpatial<IReal>,IVertex>(
			translations,
			translation => new VertexWithTranslation(translation))
	)
	{
	}
}