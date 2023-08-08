using Tumbleweed.Scalar.Nullable;
using Tumbleweed.Scalar.Nullable.Function;

namespace DotGod.Node.Spatial.Batch.Entities.Nodes;

public sealed class NodeOfEntity : Envelope<Godot.Node>
{
	public NodeOfEntity(ISpatialEntity entity) : base
	(
		new Result<Godot.Node>(
			() => entity.Node)
	)
	{
	}
}