using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces.Points;

public sealed class FromPointOfSpace : PointEnvelope<IReal>
{
	public FromPointOfSpace
	(
		ISpace occupation
	) : base
	(
		new PointOfFunction<IReal>(
			() => occupation.From)
	)
	{
	}
}