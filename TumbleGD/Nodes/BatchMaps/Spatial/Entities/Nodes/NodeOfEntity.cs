using Godot;
using Tumbleweed.Nullability;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Entities.Nodes;

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