using Tumbleweed.Booleans;
using Tumbleweed.Numerics.Fractional.Comparison;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Coordinates.Comparison;

public sealed class IsGreaterThanX : BooleanEnvelope
{
	public IsGreaterThanX
	(
		ISpatial<IFractional> first,
		ISpatial<IFractional> second
	) : base
	(
		new IsGreaterThanFractional(
			new XOfSpatial(first),
			new XOfSpatial(second))
	)
	{
	}
}