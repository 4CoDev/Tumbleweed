using DotGod.Node.Spatial.Batch.Space;
using DotGod.Node.Spatial.Batch.Space.Points;
using DotGod.Node.Spatial.Spaced.Abstract;

namespace DotGod.Node.Spatial.Batch.Have.Subbatch.By.From.Point.Of;

public sealed class Space : Tumbleweed.Boolean.Envelope
{
	public Space
	(
		IBatch batch,
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