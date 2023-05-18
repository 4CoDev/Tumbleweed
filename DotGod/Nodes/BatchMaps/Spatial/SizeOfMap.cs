using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial;

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