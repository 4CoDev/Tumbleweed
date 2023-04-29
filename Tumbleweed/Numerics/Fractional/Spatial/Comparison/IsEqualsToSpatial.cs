using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numerics.Fractional.Binaries.Singles.Comparison;
using Tumbleweed.Numerics.Fractional.Binaries.ToSystem.Singles;
using Tumbleweed.Numerics.Fractional.Comparison;
using Tumbleweed.Numerics.Fractional.Spatial.Coordinates;
using Tumbleweed.Numerics.Fractional.Spatial.Coordinates.Comparison;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Comparison;

public sealed class IsEqualsToSpatial : BooleanEnvelope
{
	public IsEqualsToSpatial
	(
		ISpatial<IFractional> first,
		ISpatial<IFractional> second
	) : base
	(
		new AndOfBooleans(
			new IsEqualsToX(first, second),
			new IsEqualsToY(first, second),
			new IsEqualsToZ(first, second))
	)
	{
	}
}