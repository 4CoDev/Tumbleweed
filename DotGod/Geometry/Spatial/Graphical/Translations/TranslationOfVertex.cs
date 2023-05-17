using DotGod.Geometry.Spatial.Graphical.Vertices;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace DotGod.Geometry.Spatial.Graphical.Translations;

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