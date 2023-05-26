using DotGod._Node.BatchMap.Entity.Placement;

namespace DotGod._Node.BatchMap.Spatial.Entities.Placement;

public sealed class PlacementOfEntity : IEntityPlacement
{
	public PlacementOfEntity
	(
		ISpatialEntity entity,
		IBatchMap root
	)
	{
		this.entity = entity;
		this.root = root;
	}
	
	public void Place()
	{
		throw new NotImplementedException();
	}

	public void Remove()
	{
		throw new NotImplementedException();
	}
	
	private readonly ISpatialEntity entity;
	
	private readonly IBatchMap root;
}