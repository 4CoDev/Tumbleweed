using Tumbleweed.Booleans;
using Tumbleweed.Numerics.Fractional.Comparison;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Coordinates.Comparison;

public sealed class IsGreaterThanZ : BooleanEnvelope
{
	public IsGreaterThanZ
	(
		ISpatial<IFractional> first,
		ISpatial<IFractional> second
	) : base
	(
		new IsGreaterThanFractional(
			new ZOfSpatial(first),
			new ZOfSpatial(second))
	)
	{
	}
}