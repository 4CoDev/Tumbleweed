using DotGod.Geometry.Graphical.Vertices;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Geometry.Graphical.Translations;

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