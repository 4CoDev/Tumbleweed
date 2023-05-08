using DotGod.Nodes.BatchMaps.Spatial.Spaces.Points;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Spatial.Arithmetics;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

public sealed class CenterOfSpace : SpatialEnvelope<IReal>
{
	public CenterOfSpace(ISpace space) : base
	(
		new QuotientByReal(
			new SumOfSpatials(
				new ToPointOfSpace(space),
				new FromPointOfSpace(space)),
			2)
	)
	{
	}
}