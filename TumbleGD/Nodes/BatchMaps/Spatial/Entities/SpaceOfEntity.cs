using TumbleGD.Nodes.BatchMaps.Spatial.Occupation;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Entities;

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