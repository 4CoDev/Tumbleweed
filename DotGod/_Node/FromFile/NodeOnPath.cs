using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod._Node.FromFile;

public sealed class NodeOnPath : Envelope<Node> 
{
	public NodeOnPath(String path) : this
	(
		new Value<String>(path)
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