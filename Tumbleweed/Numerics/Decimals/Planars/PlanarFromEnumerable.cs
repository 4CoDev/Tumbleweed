using Tumbleweed.Numerics.Planar;

namespace Tumbleweed.Numerics.Decimals.Planars;

public sealed class PlanarFromEnumerable : PlanarEnvelope<IDecimal>
{
	public PlanarFromEnumerable(IEnumerable<IDecimal> enumerable) : base
	(
		new PlanarFromCollection(
			new List<IDecimal>(enumerable))
	)
	{
	}
}