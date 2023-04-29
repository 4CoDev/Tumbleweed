using Tumbleweed.Booleans;
using Tumbleweed.Numerics.Fractional.Comparison;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Coordinates.Comparison;

public sealed class IsEqualsToX : BooleanEnvelope
{
	public IsEqualsToX
	(
		ISpatial<IFractional> first,
		ISpatial<IFractional> second
	) : base
	(
		new IsEqualsToFractional(
			new XOfSpatial(first),
			new XOfSpatial(second))
	)
	{
	}
}