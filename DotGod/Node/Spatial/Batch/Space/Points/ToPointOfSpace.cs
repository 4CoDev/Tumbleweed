using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Function;

namespace DotGod.Node.Spatial.Batch.Space.Points;

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