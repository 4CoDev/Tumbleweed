using DotGod.Node.Spatial.Batch.Space;

namespace DotGod.Node.Spatial.Batch.Entities;

public sealed class SpaceOfEntity : SpaceEnvelope
{
	public SpaceOfEntity(ISpatialEntity entity) : base
	(
		new SpaceOfFunction(
			() => entity.Occupation)
	)
	{
	}
}