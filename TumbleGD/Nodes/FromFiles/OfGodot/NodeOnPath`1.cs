using Godot;
using TumbleGD.Resources.FromFiles.ToGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.FromFiles.OfGodot;

public sealed class NodeOnPath<T> : ScalarEnvelope<T> where T : Node
{
	public NodeOnPath(String path) : this
	(
		new ScalarOfValue<String>(path)
	)
	{
	}
	
	public NodeOnPath(IScalar<String> path) : base
	(
		new ValueOfFunction<T>(
			() => new ResourceOnPath<PackedScene>(path).Value.Instantiate<T>())
	)
	{
	}
}