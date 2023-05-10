using DotGod.Geometry.Graphical.Vertices;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Geometry.Graphical.Translations;

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