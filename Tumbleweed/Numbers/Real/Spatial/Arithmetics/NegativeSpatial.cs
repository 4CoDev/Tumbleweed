using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics;

public sealed class NegativePoint : PointEnvelope<IReal>
{
	public NegativePoint
	(
		IPoint<IReal> point
	) : base
	(
		new PointWithCoordinates<IReal>(
			new NegativeReal(new XOfSpatial(point)),
			new NegativeReal(new YOfSpatial(point)),
			new NegativeReal(new ZOfSpatial(point)))
	)
	{
	}
}