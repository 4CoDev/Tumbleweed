using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;

namespace DotGod._Node.BatchMap.Spatial.Spaces.Points;

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