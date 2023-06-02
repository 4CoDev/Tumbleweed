using DotGod._Node.Batch.Entity.Placement;
using DotGod.Spatial._Node.Batch.Map;

namespace DotGod.Spatial._Node.Batch.Entities.Placement;

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