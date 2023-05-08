using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces.Points;

public sealed class ToPointOfSpace : SpatialEnvelope<IReal>
{
	public ToPointOfSpace
	(
		ISpace occupation
	) : base
	(
		new SpatialOfFunction<IReal>(
			() => occupation.To)
	)
	{
	}
}