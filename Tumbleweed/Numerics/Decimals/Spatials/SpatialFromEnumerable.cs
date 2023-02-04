using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Decimals.Spatials;

public sealed class SpatialFromEnumerable : SpatialEnvelope<IDecimal>
{
	public SpatialFromEnumerable(IEnumerable<IDecimal> enumerable) : base
	(
		new SpatialFromCollection(
			new List<IDecimal>(enumerable))
	)
	{
	}
}