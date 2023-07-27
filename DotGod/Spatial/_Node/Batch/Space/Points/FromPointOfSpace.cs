using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Function;

namespace DotGod.Spatial._Node.Batch.Space.Points;

public sealed class FromPointOfSpace : Envelope<Tumbleweed.Number.Real.Any>
{
	public FromPointOfSpace
	(
		ISpace space
	) : base
	(
		new Result<Tumbleweed.Number.Real.Any>(
			() => space.From)
	)
	{
	}
}