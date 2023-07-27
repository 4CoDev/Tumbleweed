using DotGod.Spatial._Node.Batch.Space;

namespace DotGod.Spatial._Node.Spaced.Batch.Space.Of;

public sealed class Batch : SpaceEnvelope
{
	public Batch(Abstract.IBatch batch) : base
	(
		new SpaceOfFunction(
			() => batch.Space)
	)
	{
	}
}