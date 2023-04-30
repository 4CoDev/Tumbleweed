using DotGod.Geometrics.Graphical.Vertices;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Geometrics.Graphical.Translations;

public sealed class TranslationOfVertex : SpatialEnvelope<IReal>
{
	public TranslationOfVertex(IVertex vertex) : base
	(
		new SpatialOfFunction<IReal>(
			() => vertex.Translation)
	)
	{
	}
}