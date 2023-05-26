using DotGod.Resource.FromFiles.ToGodot;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Node.FromFile;

public sealed class NodeOnPath<T> : ScalarEnvelope<T> where T : Node
{
	public NodeOnPath(String path) : this
	(
		new ScalarValue<String>(path)
	)
	{
	}
	
	public NodeOnPath(IScalar<String> path) : base
	(
		new ResultOfFunction<T>(
			() => new ResourceOnPath<PackedScene>(path).Value.Instantiate<T>())
	)
	{
	}
}