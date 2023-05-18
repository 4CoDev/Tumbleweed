using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

public sealed class IsEqualsToZ : BooleanEnvelope
{
	public IsEqualsToZ
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new IsEqualsToFractional(
			new ZOfSpatial(first),
			new ZOfSpatial(second))
	)
	{
	}
}