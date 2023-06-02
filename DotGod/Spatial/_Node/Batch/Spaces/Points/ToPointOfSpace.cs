using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial._Node.Batch.Spaces.Points;

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