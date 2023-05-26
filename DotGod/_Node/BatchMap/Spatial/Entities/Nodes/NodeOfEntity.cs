using Godot;
using Tumbleweed.Nullable;

namespace DotGod._Node.BatchMap.Spatial.Entities.Nodes;

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