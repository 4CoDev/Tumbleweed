using DotGod.Nodes.BatchMaps.Spatial.Occupation;

namespace DotGod.Nodes.BatchMaps.Spatial.Entities;

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