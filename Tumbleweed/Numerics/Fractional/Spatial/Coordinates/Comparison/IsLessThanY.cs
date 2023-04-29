using Tumbleweed.Booleans;
using Tumbleweed.Numerics.Fractional.Comparison;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Coordinates.Comparison;

public sealed class IsLessThanY : BooleanEnvelope
{
	public IsLessThanY
	(
		ISpatial<IFractional> first,
		ISpatial<IFractional> second
	) : base
	(
		new IsLessThanFractional(
			new YOfSpatial(first),
			new YOfSpatial(second))
	)
	{
	}
}