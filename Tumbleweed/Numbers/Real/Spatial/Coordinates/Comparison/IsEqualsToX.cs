using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

public sealed class IsEqualsToX : BooleanEnvelope
{
	public IsEqualsToX
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new IsEqualsToFractional(
			new XOfSpatial(first),
			new XOfSpatial(second))
	)
	{
	}
}