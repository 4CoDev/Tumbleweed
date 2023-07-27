namespace DotGod.Spatial._Node.Batch.Entities.Nodes;

public sealed class NodeOfEntity : Tumbleweed.Nullable.Envelope<Godot.Node>
{
	public NodeOfEntity(ISpatialEntity entity) : base
	(
		new Tumbleweed.Nullable.Result.Of.Function<Godot.Node>(
			() => entity.Node)
	)
	{
	}
}