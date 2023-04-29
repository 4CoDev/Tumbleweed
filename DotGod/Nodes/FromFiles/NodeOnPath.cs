using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.FromFiles;

public sealed class NodeOnPath : ScalarEnvelope<Node> 
{
	public NodeOnPath(String path) : this
	(
		new ScalarValue<String>(path)
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