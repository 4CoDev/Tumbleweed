using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

public sealed class IsLessThanY : BooleanEnvelope
{
	public IsLessThanY
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new IsLessThanFractional(
			new YOfSpatial(first),
			new YOfSpatial(second))
	)
	{
	}
}