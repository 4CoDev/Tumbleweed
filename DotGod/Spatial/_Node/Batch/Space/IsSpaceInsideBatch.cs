using Tumbleweed.Boolean;

namespace DotGod.Spatial._Node.Batch.Space;

public sealed class IsSpaceInsideBatch : Tumbleweed.Boolean.Envelope
{
	public IsSpaceInsideBatch
	(
		Spaced.Abstract.IBatch batch,
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