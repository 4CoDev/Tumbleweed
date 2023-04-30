using DotGod.Nodes.BatchMaps.Spatial.Occupation.Points;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Spatial.Arithmetics;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Occupation;

public sealed class CenterOfSpace : SpatialEnvelope<IReal>
{
	public CenterOfSpace(IOccupiedSpace space) : base
	(
		new QuotientByFractional(
			new SumOfSpatials(
				new ToPointOfSpace(space),
				new FromPointOfSpace(space)),
			2)
	)
	{
	}
}