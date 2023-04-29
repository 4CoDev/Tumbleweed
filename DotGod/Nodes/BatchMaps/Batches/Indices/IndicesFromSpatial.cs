using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Fractional.Spatial.Coordinates;
using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Numerics.Spatial;

namespace DotGod.Nodes.BatchMaps.Batches.Indices;

public sealed class IndicesFromSpatial : SpatialEnvelope<INaturalInteger>
{
	public IndicesFromSpatial(ISpatial<IFractional> spatial) : base
	(
		new SpatialWithCoordinates<INaturalInteger>(
			new IndexFromFractional(new XOfSpatial(spatial)),
			new IndexFromFractional(new YOfSpatial(spatial)),
			new IndexFromFractional(new ZOfSpatial(spatial)))
	)
	{
	}
}