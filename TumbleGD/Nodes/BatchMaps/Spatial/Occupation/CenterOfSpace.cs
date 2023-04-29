using TumbleGD.Nodes.BatchMaps.Spatial.Occupation.Points;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Fractional.Spatial.Arithmetics;
using Tumbleweed.Numerics.Spatial;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Occupation;

public sealed class CenterOfSpace : SpatialEnvelope<IFractional>
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