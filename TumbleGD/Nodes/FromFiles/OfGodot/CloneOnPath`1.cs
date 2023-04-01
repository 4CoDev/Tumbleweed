using Godot;
using TumbleGD.Resources.FromFiles.ToGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.FromFiles.OfGodot;

public sealed class CloneOnPath<T> : ScalarEnvelope<T> where T : Node
{
	public CloneOnPath(String path) : this
	(
		new ScalarValue<String>(path)
	)
	{
	}
	
	public CloneOnPath(IScalar<String> path) : base
	(
		new LazyValue<T>(
			new NodeOnPath<T>(path))
	)
	{
	}
}