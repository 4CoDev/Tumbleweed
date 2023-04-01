using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.FromFiles.OfGodot;

public sealed class CloneOnPath : ScalarEnvelope<Node> 
{
	public CloneOnPath(String path) : this
	(
		new ScalarValue<String>(path)
	)
	{
	}
	
	public CloneOnPath(IScalar<String> path) : base
	(
		new CloneOnPath<Node>(path)
	)
	{
	}
}