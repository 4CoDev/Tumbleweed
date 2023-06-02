using DotGod.Spatial._Node.Batch.Spaces;

namespace DotGod.Spatial._Node.Batch.Entities;

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