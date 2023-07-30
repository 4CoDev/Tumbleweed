using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod._Node.Path.FromSystem;

public sealed class PathFromString : Envelope<NodePath>
{
	public PathFromString(String path) : this
	(
		new Value<String>(path)
	)
	{
	}
	
	public PathFromString(Any<String> path) : base
	(
		new Actual<NodePath>(
			() => new NodePath(path.Value))
	)
	{
	}
}