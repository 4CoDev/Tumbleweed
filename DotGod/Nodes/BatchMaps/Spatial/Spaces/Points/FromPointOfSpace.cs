using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces.Points;

public sealed class FromPointOfSpace : SpatialEnvelope<IReal>
{
	public FromPointOfSpace
	(
		ISpace occupation
	) : base
	(
		new SpatialOfFunction<IReal>(
			() => occupation.From)
	)
	{
	}
}