using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

public sealed class IsLessThanZ : BooleanEnvelope
{
	public IsLessThanZ
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new IsLessThanFractional(
			new ZOfSpatial(first),
			new ZOfSpatial(second))
	)
	{
	}
}