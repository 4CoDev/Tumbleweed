using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

public sealed class IsGreaterThanX : BooleanEnvelope
{
	public IsGreaterThanX
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new IsGreaterThanFractional(
			new XOfSpatial(first),
			new XOfSpatial(second))
	)
	{
	}
}