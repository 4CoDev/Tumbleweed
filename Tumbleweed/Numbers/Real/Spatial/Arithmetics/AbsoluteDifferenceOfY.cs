using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics;

public sealed class AbsoluteDifferenceOfY : RealEnvelope
{
	public AbsoluteDifferenceOfY
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new AbsoluteDifferenceOfReals(
			new YOfSpatial(first),
			new YOfSpatial(second))
	)
	{
	}
}