using Tumbleweed.Booleans;
using Tumbleweed.Numerics.Fractional.Comparison;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Coordinates.Comparison;

public sealed class IsLessThanZ : BooleanEnvelope
{
	public IsLessThanZ
	(
		ISpatial<IFractional> first,
		ISpatial<IFractional> second
	) : base
	(
		new IsLessThanFractional(
			new ZOfSpatial(first),
			new ZOfSpatial(second))
	)
	{
	}
}