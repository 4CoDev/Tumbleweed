using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Node.FromFile;

public sealed class CloneOnPath : Envelope<Node> 
{
	public CloneOnPath(String path) : this
	(
		new Tumbleweed.Scalar.Of.Value<String>(path)
	)
	{
	}
	
	public CloneOnPath(Any<String> path) : base
	(
		new CloneOnPath<Node>(path)
	)
	{
	}
}