using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Function;

namespace DotGod._Node.Path.FromSystem;

public sealed class PathFromString : Envelope<NodePath>
{
	public PathFromString(String path) : this
	(
		new Tumbleweed.Scalar.Of.Value<String>(path)
	)
	{
	}
	
	public PathFromString(Any<String> path) : base
	(
		new Tumbleweed.Scalar.Function.Result<NodePath>(
			() => new NodePath(path.Value))
	)
	{
	}
}