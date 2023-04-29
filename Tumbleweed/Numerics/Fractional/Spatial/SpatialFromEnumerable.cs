using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial;

public sealed class SpatialFromEnumerable : SpatialEnvelope<IFractional>
{
	public SpatialFromEnumerable(IEnumerable<IFractional> enumerable) : base
	(
		new SpatialFromCollection(
			new List<IFractional>(enumerable))
	)
	{
	}
}