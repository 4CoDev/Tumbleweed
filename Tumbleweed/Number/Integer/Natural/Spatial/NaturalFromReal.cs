using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Coordinate;
using NaturalNumberFromReal =
	Tumbleweed.Number.Integer.Natural.NaturalFromReal;

namespace Tumbleweed.Number.Integer.Natural.Spatial;

public sealed class NaturalFromReal : PointEnvelope<INatural>
{
	public NaturalFromReal(IPoint<IReal> real) : base
	(
		new PointWithCoordinates(
			new NaturalNumberFromReal(new XOfPoint(real)),
			new NaturalNumberFromReal(new YOfPoint(real)),
			new NaturalNumberFromReal(new ZOfPoint(real)))
	)
	{
	}
}