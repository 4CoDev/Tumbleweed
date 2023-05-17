using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Points.Spatial;

namespace DotGod.Nodes.BatchMaps.Batches.Indices;

public sealed class IndicesFromSpatial : SpatialEnvelope<INatural>
{
	public IndicesFromSpatial(ISpatial<IReal> spatial) : base
	(
		new SpatialWithCoordinates<INatural>(
			new IndexFromFractional(new XOfSpatial(spatial)),
			new IndexFromFractional(new YOfSpatial(spatial)),
			new IndexFromFractional(new ZOfSpatial(spatial)))
	)
	{
	}
}