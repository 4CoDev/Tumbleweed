using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Spatial;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Occupation.Points;

public sealed class ToPointOfSpace : SpatialEnvelope<IFractional>
{
	public ToPointOfSpace
	(
		IOccupiedSpace occupation
	) : base
	(
		new SpatialOfFunction<IFractional>(
			() => occupation.To)
	)
	{
	}
}