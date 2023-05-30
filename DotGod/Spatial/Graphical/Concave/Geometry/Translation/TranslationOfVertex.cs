using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Translation;

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