using Tumbleweed.Booleans;
using Tumbleweed.Numerics.Fractional.Comparison;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Coordinates.Comparison;

public sealed class IsGreaterThanY : BooleanEnvelope
{
	public IsGreaterThanY
	(
		ISpatial<IFractional> first,
		ISpatial<IFractional> second
	) : base
	(
		new IsGreaterThanFractional(
			new YOfSpatial(first),
			new YOfSpatial(second))
	)
	{
	}
}