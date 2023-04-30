using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Occupation.Points;

public sealed class ToPointOfSpace : SpatialEnvelope<IReal>
{
	public ToPointOfSpace
	(
		IOccupiedSpace occupation
	) : base
	(
		new SpatialOfFunction<IReal>(
			() => occupation.To)
	)
	{
	}
}