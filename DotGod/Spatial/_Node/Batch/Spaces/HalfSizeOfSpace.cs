using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;
using Tumbleweed.Spatial.Point.Real.Arithmetic;

namespace DotGod.Spatial._Node.Batch.Spaces;

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