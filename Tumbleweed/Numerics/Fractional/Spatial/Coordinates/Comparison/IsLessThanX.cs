using Tumbleweed.Booleans;
using Tumbleweed.Numerics.Fractional.Comparison;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Coordinates.Comparison;

public sealed class IsLessThanX : BooleanEnvelope
{
	public IsLessThanX
	(
		ISpatial<IFractional> first,
		ISpatial<IFractional> second
	) : base
	(
		new IsLessThanFractional(
			new XOfSpatial(first),
			new XOfSpatial(second))
	)
	{
	}
}