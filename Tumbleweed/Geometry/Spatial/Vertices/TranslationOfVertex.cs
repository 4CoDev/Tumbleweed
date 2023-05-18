using Tumbleweed.Points.Spatial;
using IRealNumber = Tumbleweed.Numbers.Real.IReal;

namespace Tumbleweed.Geometry.Spatial.Vertices;

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