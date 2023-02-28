using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.FromFiles.OfGodot;

public sealed class NodeOnPath : ScalarEnvelope<Node> 
{
	public NodeOnPath(string path) : this
	(
		new ScalarOfValue<string>(path)
	)
	{
	}
	
	public NodeOnPath(IScalar<string> path) : base
	(
		new NodeOnPath<Node>(path)
	)
	{
	}
}