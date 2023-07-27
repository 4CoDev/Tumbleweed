using DotGod.Spatial._Node.Batch.Space.Points;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Arithmetic.Distance;

namespace DotGod.Spatial._Node.Batch.Space;

public sealed class SizeOfSpace : Envelope<Tumbleweed.Number.Real.Any>
{
	public SizeOfSpace(ISpace space) : base
	(
		new L1BetweenPoints(
			new FromPointOfSpace(space),
			new ToPointOfSpace(space))
	)
	{
	}
}