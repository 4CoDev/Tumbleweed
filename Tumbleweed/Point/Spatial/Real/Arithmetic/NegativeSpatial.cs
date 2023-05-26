using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Point.Spatial.Real.Coordinate;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic;

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