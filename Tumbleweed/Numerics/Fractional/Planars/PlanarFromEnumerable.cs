using Tumbleweed.Numerics.Planar;

namespace Tumbleweed.Numerics.Fractional.Planars;

public sealed class PlanarFromEnumerable : PlanarEnvelope<IFractional>
{
	public PlanarFromEnumerable(IEnumerable<IFractional> enumerable) : base
	(
		new PlanarFromCollection(
			new List<IFractional>(enumerable))
	)
	{
	}
}