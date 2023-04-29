using Tumbleweed.Booleans;
using Tumbleweed.Numerics.Fractional.Comparison;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Coordinates.Comparison;

public sealed class IsEqualsToZ : BooleanEnvelope
{
	public IsEqualsToZ
	(
		ISpatial<IFractional> first,
		ISpatial<IFractional> second
	) : base
	(
		new IsEqualsToFractional(
			new ZOfSpatial(first),
			new ZOfSpatial(second))
	)
	{
	}
}