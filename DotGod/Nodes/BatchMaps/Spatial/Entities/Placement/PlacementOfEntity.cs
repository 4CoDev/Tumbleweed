using DotGod.Nodes.BatchMaps.Entities.Placement;

namespace DotGod.Nodes.BatchMaps.Spatial.Entities.Placement;

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