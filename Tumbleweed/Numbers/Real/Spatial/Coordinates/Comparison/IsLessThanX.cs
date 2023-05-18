using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

public sealed class IsLessThanX : BooleanEnvelope
{
	public IsLessThanX
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new IsLessThanFractional(
			new XOfSpatial(first),
			new XOfSpatial(second))
	)
	{
	}
}