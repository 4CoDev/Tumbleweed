using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Node.FromFile;

public sealed class NodeOnPath : Envelope<Node> 
{
	public NodeOnPath(String path) : this
	(
		new Tumbleweed.Scalar.Of.Value<String>(path)
	)
	{
	}
	
	public NodeOnPath(Any<String> path) : base
	(
		new NodeOnPath<Node>(path)
	)
	{
	}
}