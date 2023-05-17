using Tumbleweed.Points.Spatial;
using IRealNumber = Tumbleweed.Numbers.Real.IReal;

namespace Tumbleweed.Geometry.Spatial.Vertices;

public sealed class TranslationOfVertex : SpatialEnvelope<IRealNumber>
{
	public TranslationOfVertex(IVertex vertex) : base
	(
		new SpatialOfFunction<IRealNumber>(
			() => vertex.Translation)
	)
	{
	}
}