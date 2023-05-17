using DotGod.Geometry.Spatial.Graphical.Vertices;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace DotGod.Geometry.Spatial.Graphical.Translations;

public sealed class LazyTranslationOfVertex : SpatialEnvelope<IReal>
{
	public LazyTranslationOfVertex(IVertex vertex) : base
	(
		new LazySpatial<IReal>(
			new TranslationOfVertex(vertex))
	)
	{
	}
}