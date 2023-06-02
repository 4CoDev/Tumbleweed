using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial._Node.Batch.Map;

public sealed class SizeOfMap : PointEnvelope<IReal>
{
	public SizeOfMap(IBatchMap map) : base
	(
		new PointOfFunction<IReal>(
			() => map.Size)
	)
	{
	}
}