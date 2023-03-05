using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.FromFiles.OfGodot;

public sealed class NodeOnPath : ScalarEnvelope<Node> 
{
	public NodeOnPath(String path) : this
	(
		new ScalarOfValue<String>(path)
	)
	{
	}
	
	public NodeOnPath(IScalar<String> path) : base
	(
		new NodeOnPath<Node>(path)
	)
	{
	}
}