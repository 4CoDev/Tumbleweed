using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Comparison;

public sealed class IsLessThanOrEqualsToSpatial : BooleanEnvelope
{
	public IsLessThanOrEqualsToSpatial
	(
		IPoint<IReal> first,
		IPoint<IReal> second
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