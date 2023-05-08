using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Spatial.Arithmetics;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

public sealed class HalfOfSpace : SpatialEnvelope<IReal>
{
	public HalfOfSpace(ISpace space) : base
	(
		new QuotientByReal(
			new SizeOfSpace(space), 2)
	)
	{
	}
}