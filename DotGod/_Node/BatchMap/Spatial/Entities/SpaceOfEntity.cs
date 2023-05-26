using DotGod._Node.BatchMap.Spatial.Spaces;

namespace DotGod._Node.BatchMap.Spatial.Entities;

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