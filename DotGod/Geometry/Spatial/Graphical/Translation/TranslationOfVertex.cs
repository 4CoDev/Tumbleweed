using DotGod.Geometry.Spatial.Graphical.Vertex;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;

namespace DotGod.Geometry.Spatial.Graphical.Translation;

public sealed class TranslationOfVertex : PointEnvelope<IReal>
{
	public TranslationOfVertex(IVertex vertex) : base
	(
		new PointOfFunction<IReal>(
			() => vertex.Translation)
	)
	{
	}
}