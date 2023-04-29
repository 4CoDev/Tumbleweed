using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Occupation.Points;

public sealed class FromPointOfSpace : SpatialEnvelope<IFractional>
{
	public FromPointOfSpace
	(
		IOccupiedSpace occupation
	) : base
	(
		new SpatialOfFunction<IFractional>(
			() => occupation.From)
	)
	{
	}
}