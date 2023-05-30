using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Spatial.Point.Real.Coordinate;

namespace Tumbleweed.Spatial.Point.Real.Arithmetic;

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