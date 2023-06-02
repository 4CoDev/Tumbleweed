using Godot;
using Tumbleweed.Nullable;

namespace DotGod.Spatial._Node.Batch.Entities.Nodes;

public sealed class NodeOfEntity : NullableEnvelope<Node>
{
	public NodeOfEntity(ISpatialEntity entity) : base
	(
		new NullableOfFunction<Node>(
			() => entity.Node)
	)
	{
	}
}