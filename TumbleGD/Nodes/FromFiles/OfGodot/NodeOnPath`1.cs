using Godot;
using TumbleGD.Resources.FromFiles.ToGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.FromFiles.OfGodot;

public sealed class NodeOnPath<T> : ScalarEnvelope<T> where T : Node
{
	public NodeOnPath(string path) : this
	(
		new ScalarOfValue<string>(path)
	)
	{
	}
	
	public NodeOnPath(IScalar<string> path) : base
	(
		new ValueOfDelegate<T>(
			() => new ScalarOnPath<PackedScene>(path).Value.Instantiate<T>())
	)
	{
	}
}