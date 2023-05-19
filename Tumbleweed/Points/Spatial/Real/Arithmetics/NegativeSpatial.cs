using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Points.Spatial.Real.Coordinates;

namespace Tumbleweed.Points.Spatial.Real.Arithmetics;

public sealed class NegativePoint : PointEnvelope<IReal>
{
	public NegativePoint
	(
		IPoint<IReal> point
	) : base
	(
		new PointWithCoordinates<IReal>(
			new NegativeReal(new XOfPoint(point)),
			new NegativeReal(new YOfPoint(point)),
			new NegativeReal(new ZOfPoint(point)))
	)
	{
	}
}