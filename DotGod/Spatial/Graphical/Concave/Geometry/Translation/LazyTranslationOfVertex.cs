using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Translation;

public sealed class LazyTranslationOfVertex : Envelope<Any>
{
	public LazyTranslationOfVertex(IVertex vertex) : base
	(
		new Tumbleweed.Point.Spatial.Lazy<Any>(
			new TranslationOfVertex(vertex))
	)
	{
	}
}