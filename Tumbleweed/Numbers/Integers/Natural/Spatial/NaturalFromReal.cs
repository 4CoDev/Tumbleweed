using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Points.Spatial;
using NaturalNumberFromReal =
	Tumbleweed.Numbers.Integers.Natural.NaturalFromReal;

namespace Tumbleweed.Numbers.Integers.Natural.Spatial;

public sealed class NaturalFromReal : PointEnvelope<INatural>
{
	public NaturalFromReal(IPoint<IReal> real) : base
	(
		new PointWithCoordinates(
			new NaturalNumberFromReal(new XOfSpatial(real)),
			new NaturalNumberFromReal(new YOfSpatial(real)),
			new NaturalNumberFromReal(new ZOfSpatial(real)))
	)
	{
	}
}