using Tumbleweed.Spatial.Point;
using IRealNumber = Tumbleweed.Number.Real.IReal;

namespace Tumbleweed.Spatial.Geometry.Vertex;

public sealed class TranslationOfVertex : PointEnvelope<IRealNumber>
{
	public TranslationOfVertex(IVertex vertex) : base
	(
		new PointOfFunction<IRealNumber>(
			() => vertex.Translation)
	)
	{
	}
}