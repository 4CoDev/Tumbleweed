using DotGod.Geometrics.Graphical.Vertices;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Spatial;

namespace DotGod.Geometrics.Graphical.Translations;

public sealed class LazyTranslationOfVertex : SpatialEnvelope<IFractional>
{
	public LazyTranslationOfVertex(IVertex vertex) : base
	(
		new LazySpatial<IFractional>(
			new TranslationOfVertex(vertex))
	)
	{
	}
}