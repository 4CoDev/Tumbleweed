using Tumbleweed.Booleans;
using Tumbleweed.Numerics.Fractional.Comparison;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Coordinates.Comparison;

public sealed class IsEqualsToY : BooleanEnvelope
{
	public IsEqualsToY
	(
		ISpatial<IFractional> first,
		ISpatial<IFractional> second
	) : base
	(
		new IsEqualsToFractional(
			new YOfSpatial(first),
			new YOfSpatial(second))
	)
	{
	}
}