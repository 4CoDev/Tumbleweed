using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.Real.Coordinates;
using NaturalNumberFromReal =
	Tumbleweed.Numbers.Integers.Natural.NaturalFromReal;

namespace Tumbleweed.Numbers.Integers.Natural.Spatial;

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