using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Spatial;

namespace TumbleGD.Geometrics.Graphical.Translations;

public sealed class TranslationOfVertex : SpatialEnvelope<IFractional>
{
	public TranslationOfVertex(IVertex vertex) : base
	(
		new SpatialOfFunction<IFractional>(
			() => vertex.Translation)
	)
	{
	}
}