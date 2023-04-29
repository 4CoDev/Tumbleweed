using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numerics.Fractional.Comparison;
using Tumbleweed.Numerics.Fractional.Spatial.Coordinates;
using Tumbleweed.Numerics.Fractional.Spatial.Coordinates.Comparison;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Comparison;

public sealed class IsGreaterThanOrEqualsToSpatial : BooleanEnvelope
{
	public IsGreaterThanOrEqualsToSpatial
	(
		ISpatial<IFractional> first,
		ISpatial<IFractional> second
	) : base
	(
		new AndOfBooleans(
			new IsGreaterThanOrEqualsToX(first, second),
			new IsGreaterThanOrEqualsToY(first, second),
			new IsGreaterThanOrEqualsToZ(first, second))
	)
	{
	}
}