using DotGod.Spatial._Node.Batch.Space;
using DotGod.Spatial._Node.Batch.Space.Points;
using Tumbleweed.Boolean;

namespace DotGod.Spatial._Node.Batch.Have.Subbatch.By.From.Point.Of;

public sealed class Space : Tumbleweed.Boolean.Envelope
{
	public Space
	(
		Spaced.Abstract.IBatch batch,
		ISpace space
	) : base
	(
		new By.Point(
			batch,
			new FromPointOfSpace(space))
	)
	{
	}
}