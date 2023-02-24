using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Paths.FromSystem;

public sealed class PathFromString : ScalarEnvelope<NodePath>
{
	public PathFromString(string path) : this
	(
		new ScalarOfValue<string>(path)
	)
	{
	}
	
	public PathFromString(IScalar<string> path) : base
	(
		new ScalarOfDelegate<NodePath>(
			() => new NodePath(path.Value))
	)
	{
	}
}