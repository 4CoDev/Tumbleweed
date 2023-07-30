using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod._Node.FromFile;

public sealed class CloneOnPath<T> : Envelope<T> where T : Node
{
	public CloneOnPath(String path) : this
	(
		new Value<String>(path)
	)
	{
	}
	
	public CloneOnPath(Any<String> path) : base
	(
		new Tumbleweed.Scalar.Immutable.Lazy<T>(
			new NodeOnPath<T>(path))
	)
	{
	}
}