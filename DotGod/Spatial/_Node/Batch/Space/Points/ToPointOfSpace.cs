using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Function;

namespace DotGod.Spatial._Node.Batch.Space.Points;

public sealed class ToPointOfSpace : Envelope<Tumbleweed.Number.Real.Any>
{
	public ToPointOfSpace
	(
		ISpace occupation
	) : base
	(
		new Result<Tumbleweed.Number.Real.Any>(
			() => occupation.To)
	)
	{
	}
}