using Tumbleweed.Numerics.Decimals.FromCollection.FromSystem;
using Tumbleweed.Numerics.Planar;

namespace Tumbleweed.Numerics.Decimals.Planars;

public sealed class PlanarFromCollection : PlanarEnvelope<IDecimal>
{
	public PlanarFromCollection(ICollection<IDecimal> collection) : base
	(
		new PlanarWithValues<IDecimal>(
			new DecimalWithIndex(collection, 0),
			new DecimalWithIndex(collection, 1))
	)
	{
	}
}