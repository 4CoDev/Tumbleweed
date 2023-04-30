using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;
using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Comparison;

public sealed class IsGreaterThanOrEqualsToSpatial : BooleanEnvelope
{
	public IsGreaterThanOrEqualsToSpatial
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
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