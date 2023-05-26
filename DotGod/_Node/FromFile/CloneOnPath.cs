using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Node.FromFile;

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