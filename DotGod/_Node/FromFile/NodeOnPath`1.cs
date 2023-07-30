using DotGod.Resource.FromFiles.ToGodot;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod._Node.FromFile;

public sealed class NodeOnPath<T> : Envelope<T> where T : Node
{
	public NodeOnPath(String path) : this
	(
		new Value<String>(path)
	)
	{
	}
	
	public NodeOnPath(Any<String> path) : base
	(
		new Actual<T>(
			() => new ResourceOnPath<PackedScene>(path).Value.Instantiate<T>())
	)
	{
	}
}