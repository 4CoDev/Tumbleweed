using DotGod.Node.Spatial.Batch.Space;
using DotGod.Node.Spatial.Batch.Space.Points;

namespace DotGod.Node.Spatial.Spaced.Batch.Subbatch.By.From.Point.Of;

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