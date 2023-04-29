using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Spatial;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Occupation.Points;

public sealed class BothPointsOfSpace :
	EnumerableEnvelope<ISpatial<IFractional>>
{
	public BothPointsOfSpace(IOccupiedSpace occupation) : base
	(
		new EnumerableWithElements<ISpatial<IFractional>>(
			new FromPointOfSpace(occupation),
			new ToPointOfSpace(occupation))
	)
	{
	}
}