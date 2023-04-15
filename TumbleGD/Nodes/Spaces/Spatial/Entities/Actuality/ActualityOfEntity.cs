using TumbleGD.Nodes.Spaces.Entities.Actuality;

namespace TumbleGD.Nodes.Spaces.Spatial.Entities.Actuality;

public sealed class ActualityOfEntity : IPlacementActuality
{
	public ActualityOfEntity
	(
		ISpatialEntity entity,
		ISpatialSpace space
	)
	{
		this.entity = entity;
		this.space = space;
	}
	
	public void Update()
	{
		throw new NotImplementedException();
	}

	private readonly ISpatialEntity entity;
	
	private readonly ISpatialSpace space;
}