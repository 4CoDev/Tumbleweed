using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;

namespace DotGod._Node.BatchMap.Spatial.Spaces.Points;

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