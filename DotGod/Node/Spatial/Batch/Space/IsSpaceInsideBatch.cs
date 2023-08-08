using DotGod.Node.Spatial.Spaced.Abstract;

namespace DotGod.Node.Spatial.Batch.Space;

public sealed class IsSpaceInsideBatch : Tumbleweed.Boolean.Envelope
{
	public IsSpaceInsideBatch
	(
		IBatch batch,
		ISpace space
	) : base
	(
		new IsSpaceInsideSpace(
			space,
			new Spaced.Batch.Space.Of.Batch(batch))
	)
	{
	}
}