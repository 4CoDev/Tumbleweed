using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Arithmetic;

namespace DotGod.Node.Spatial.Batch.Space;

public sealed class HalfOfSpace : Envelope<Tumbleweed.Number.Real.Any>
{
	public HalfOfSpace(ISpace space) : base
	(
		new QuotientByReal(
			new SizeOfSpace(space), 2)
	)
	{
	}
}