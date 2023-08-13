namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Placement;

public sealed class One : DotGod.Node.Batch.Entity.Placement.Any
{
	public One
	(
		Any entity,
		Map.Any root
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
	
	private readonly Any entity;
	
	private readonly Map.Any root;
}