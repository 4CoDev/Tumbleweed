using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces.Points;

public sealed class BothPointsOfSpace :
	EnumerableEnvelope<ISpatial<IReal>>
{
	public BothPointsOfSpace(ISpace occupation) : base
	(
		new EnumerableWithElements<ISpatial<IReal>>(
			new FromPointOfSpace(occupation),
			new ToPointOfSpace(occupation))
	)
	{
	}
}