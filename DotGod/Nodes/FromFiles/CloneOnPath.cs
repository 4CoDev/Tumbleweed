using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.FromFiles;

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