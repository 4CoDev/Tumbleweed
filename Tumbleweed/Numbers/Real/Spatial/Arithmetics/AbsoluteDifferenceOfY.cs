using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics;

public sealed class AbsoluteDifferenceOfY : RealEnvelope
{
	public AbsoluteDifferenceOfY
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
	) : base
	(
		new AbsoluteDifferenceOfReals(
			new YOfSpatial(first),
			new YOfSpatial(second))
	)
	{
	}
}