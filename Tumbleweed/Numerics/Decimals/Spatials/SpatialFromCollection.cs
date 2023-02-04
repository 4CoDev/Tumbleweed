using Tumbleweed.Numerics.Decimals.FromCollection.FromSystem;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Decimals.Spatials;

public sealed class SpatialFromCollection : SpatialEnvelope<IDecimal>
{
	public SpatialFromCollection(ICollection<IDecimal> collection) : base
	(
		new SpatialWithValues<IDecimal>(
			new DecimalWithIndex(collection, 0),
			new DecimalWithIndex(collection, 1),
			new DecimalWithIndex(collection, 2))
	)
	{
	}
}