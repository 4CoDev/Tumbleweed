using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Spatial;

namespace TumbleGD.Nodes.BatchMaps.Spatial;

public sealed class SizeOfMap : SpatialEnvelope<IFractional>
{
	public SizeOfMap(IBatchMap map) : base
	(
		new SpatialOfFunction<IFractional>(
			() => map.Size)
	)
	{
	}
}