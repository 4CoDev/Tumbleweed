using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Spatial.Arithmetics;
using Tumbleweed.Points.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

public sealed class HalfOfSpace : PointEnvelope<IReal>
{
	public HalfOfSpace(ISpace space) : base
	(
		new QuotientByReal(
			new SizeOfSpace(space), 2)
	)
	{
	}
}