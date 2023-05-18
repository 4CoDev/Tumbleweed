using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Comparison;

public sealed class IsGreaterThanOrEqualsToSpatial : BooleanEnvelope
{
	public IsGreaterThanOrEqualsToSpatial
	(
		IPoint<IReal> first,
		IPoint<IReal> second
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