using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial;

public sealed class SizeOfMap : SpatialEnvelope<IReal>
{
	public SizeOfMap(IBatchMap map) : base
	(
		new SpatialOfFunction<IReal>(
			() => map.Size)
	)
	{
	}
}