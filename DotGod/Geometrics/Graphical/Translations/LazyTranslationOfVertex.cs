using DotGod.Geometrics.Graphical.Vertices;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Geometrics.Graphical.Translations;

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