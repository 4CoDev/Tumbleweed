using DotGod.Nodes.BatchMaps.Spatial.Spaces.Points;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Spatial.Arithmetics.Distances;
using Tumbleweed.Points.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

public sealed class SizeOfSpace : PointEnvelope<IReal>
{
	public SizeOfSpace(ISpace space) : base
	(
		new L1BetweenPoints(
			new FromPointOfSpace(space),
			new ToPointOfSpace(space))
	)
	{
	}
}