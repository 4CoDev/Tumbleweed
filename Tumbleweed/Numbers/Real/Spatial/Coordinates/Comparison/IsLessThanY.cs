using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

public sealed class IsLessThanY : BooleanEnvelope
{
	public IsLessThanY
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
	) : base
	(
		new IsLessThanFractional(
			new YOfSpatial(first),
			new YOfSpatial(second))
	)
	{
	}
}