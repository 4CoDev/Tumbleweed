using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Paths.FromSystem;

public sealed class PathFromString : ScalarEnvelope<NodePath>
{
	public PathFromString(String path) : this
	(
		new ScalarOfValue<String>(path)
	)
	{
	}
	
	public PathFromString(IScalar<String> path) : base
	(
		new ValueOfDelegate<NodePath>(
			() => new NodePath(path.Value))
	)
	{
	}
}