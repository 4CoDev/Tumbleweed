using Tumbleweed.Point.Spatial;
using IRealNumber = Tumbleweed.Number.Real.IReal;

namespace Tumbleweed.Geometry.Spatial.Vertex;

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