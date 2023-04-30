using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

public sealed class IsLessThanX : BooleanEnvelope
{
	public IsLessThanX
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
	) : base
	(
		new IsLessThanFractional(
			new XOfSpatial(first),
			new XOfSpatial(second))
	)
	{
	}
}