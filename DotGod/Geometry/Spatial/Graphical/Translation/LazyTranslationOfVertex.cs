using DotGod.Geometry.Spatial.Graphical.Vertex;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;

namespace DotGod.Geometry.Spatial.Graphical.Translation;

public sealed class LazyTranslationOfVertex : PointEnvelope<IReal>
{
	public LazyTranslationOfVertex(IVertex vertex) : base
	(
		new LazyPoint<IReal>(
			new TranslationOfVertex(vertex))
	)
	{
	}
}