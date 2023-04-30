using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Occupation.Points;

public sealed class FromPointOfSpace : SpatialEnvelope<IReal>
{
	public FromPointOfSpace
	(
		IOccupiedSpace occupation
	) : base
	(
		new SpatialOfFunction<IReal>(
			() => occupation.From)
	)
	{
	}
}