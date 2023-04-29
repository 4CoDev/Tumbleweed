using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numerics.Fractional.Binaries.Singles.Comparison;
using Tumbleweed.Numerics.Fractional.Binaries.ToSystem.Singles;
using Tumbleweed.Numerics.Fractional.Spatial.Coordinates.Comparison;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Comparison;

public sealed class IsLessThanOrEqualsToSpatial : BooleanEnvelope
{
	public IsLessThanOrEqualsToSpatial
	(
		ISpatial<IFractional> first,
		ISpatial<IFractional> second
	) : base
	(
		new AndOfBooleans(
			new IsLessThanOrEqualsToX(first, second),
			new IsLessThanOrEqualsToY(first, second),
			new IsLessThanOrEqualsToZ(first, second))
	)
	{
	}
}