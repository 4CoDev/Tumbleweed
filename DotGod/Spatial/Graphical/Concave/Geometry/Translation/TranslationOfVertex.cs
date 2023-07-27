using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Function;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Translation;

public sealed class TranslationOfVertex : Envelope<Any>
{
	public TranslationOfVertex(IVertex vertex) : base
	(
		new Result<Any>(
			() => vertex.Translation)
	)
	{
	}
}