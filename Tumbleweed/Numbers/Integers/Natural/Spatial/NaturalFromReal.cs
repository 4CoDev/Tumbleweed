using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Numbers.Spatial;
using NaturalNumberFromReal =
	Tumbleweed.Numbers.Integers.Natural.NaturalFromReal;

namespace Tumbleweed.Numbers.Integers.Natural.Spatial;

public sealed class NaturalFromReal : SpatialEnvelope<INatural>
{
	public NaturalFromReal(ISpatial<IReal> real) : base
	(
		new SpatialWithCoordinates(
			new NaturalNumberFromReal(new XOfSpatial(real)),
			new NaturalNumberFromReal(new YOfSpatial(real)),
			new NaturalNumberFromReal(new ZOfSpatial(real)))
	)
	{
	}
}