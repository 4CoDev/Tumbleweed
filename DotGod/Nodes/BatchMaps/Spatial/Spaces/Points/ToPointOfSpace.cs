using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces.Points;

public sealed class ToPointOfSpace : PointEnvelope<IReal>
{
	public ToPointOfSpace
	(
		ISpace occupation
	) : base
	(
		new PointOfFunction<IReal>(
			() => occupation.To)
	)
	{
	}
}