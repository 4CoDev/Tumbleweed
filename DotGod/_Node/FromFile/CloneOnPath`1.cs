using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Lazy;

namespace DotGod._Node.FromFile;

public sealed class CloneOnPath<T> : Envelope<T> where T : Node
{
	public CloneOnPath(String path) : this
	(
		new Tumbleweed.Scalar.Of.Value<String>(path)
	)
	{
	}
	
	public CloneOnPath(Any<String> path) : base
	(
		new OfValue<T>(
			new NodeOnPath<T>(path))
	)
	{
	}
}