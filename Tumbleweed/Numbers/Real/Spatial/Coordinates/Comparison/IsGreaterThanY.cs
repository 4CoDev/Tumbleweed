using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

public sealed class IsGreaterThanY : BooleanEnvelope
{
	public IsGreaterThanY
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
	) : base
	(
		new IsGreaterThanFractional(
			new YOfSpatial(first),
			new YOfSpatial(second))
	)
	{
	}
}