using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numerics.Fractional.Comparison;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Coordinates.Comparison;

public sealed class IsLessThanOrEqualsToZ : BooleanEnvelope
{
	public IsLessThanOrEqualsToZ
	(
		ISpatial<IFractional> first,
		ISpatial<IFractional> second
	) : base
	(
		new OrOfTwoBooleans(
			new IsLessThanZ(first, second),
			new IsEqualsToZ(first, second))
	)
	{
	}
}