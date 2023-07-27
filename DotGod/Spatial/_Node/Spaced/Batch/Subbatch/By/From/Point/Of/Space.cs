using DotGod.Spatial._Node.Batch.Space;
using DotGod.Spatial._Node.Batch.Space.Points;

namespace DotGod.Spatial._Node.Spaced.Batch.Subbatch.By.From.Point.Of;

public sealed class Space : Envelope
{
	public Space(Abstract.IBatch batch, ISpace space) : base
	(
		new By.Point(
			batch,
			new FromPointOfSpace(space))
	)
	{
	}
}