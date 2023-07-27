using DotGod.Resource.FromFiles.ToGodot;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Function;

namespace DotGod._Node.FromFile;

public sealed class NodeOnPath<T> : Envelope<T> where T : Node
{
	public NodeOnPath(String path) : this
	(
		new Tumbleweed.Scalar.Of.Value<String>(path)
	)
	{
	}
	
	public NodeOnPath(Any<String> path) : base
	(
		new Tumbleweed.Scalar.Function.Result<T>(
			() => new ResourceOnPath<PackedScene>(path).Value.Instantiate<T>())
	)
	{
	}
}