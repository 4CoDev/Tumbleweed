using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;
using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Comparison;

public sealed class IsEqualsToSpatial : BooleanEnvelope
{
	public IsEqualsToSpatial
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
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