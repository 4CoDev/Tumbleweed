using DotGod.Node.Spatial.Batch.Space;

namespace DotGod.Node.Spatial.Spaced.Batch.Space.Of;

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