using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;

namespace DotGod._Node.BatchMap.Spatial;

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