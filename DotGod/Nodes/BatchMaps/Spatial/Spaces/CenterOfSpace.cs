using DotGod.Nodes.BatchMaps.Spatial.Spaces.Points;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Spatial.Arithmetics;
using Tumbleweed.Points.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

public sealed class CenterOfSpace : PointEnvelope<IReal>
{
	public CenterOfSpace(ISpace space) : base
	(
		new QuotientByReal(
			new SumOfPoints(
				new ToPointOfSpace(space),
				new FromPointOfSpace(space)),
			2)
	)
	{
	}
}