using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces.Points;

public sealed class BothPointsOfSpace :
	EnumerableEnvelope<IPoint<IReal>>
{
	public BothPointsOfSpace(ISpace occupation) : base
	(
		new EnumerableWithElements<IPoint<IReal>>(
			new FromPointOfSpace(occupation),
			new ToPointOfSpace(occupation))
	)
	{
	}
}