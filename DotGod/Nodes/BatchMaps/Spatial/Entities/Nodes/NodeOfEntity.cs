using Godot;
using Tumbleweed.Nullables;

namespace DotGod.Nodes.BatchMaps.Spatial.Entities.Nodes;

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