using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.Paths.FromSystem;

public sealed class PathFromString : ScalarEnvelope<NodePath>
{
	public PathFromString(String path) : this
	(
		new ScalarValue<String>(path)
	)
	{
	}
	
	public PathFromString(IScalar<String> path) : base
	(
		new ValueOfFunction<NodePath>(
			() => new NodePath(path.Value))
	)
	{
	}
}