using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Translation;

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