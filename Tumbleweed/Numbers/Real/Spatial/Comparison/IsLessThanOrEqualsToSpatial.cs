using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Comparison;

public sealed class IsLessThanOrEqualsToSpatial : BooleanEnvelope
{
	public IsLessThanOrEqualsToSpatial
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
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