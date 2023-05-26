using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Node.Path.FromSystem;

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
		new ResultOfFunction<NodePath>(
			() => new NodePath(path.Value))
	)
	{
	}
}