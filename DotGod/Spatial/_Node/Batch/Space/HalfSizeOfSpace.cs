using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Arithmetic;

namespace DotGod.Spatial._Node.Batch.Space;

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