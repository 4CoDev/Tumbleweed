using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.With;

// ReSharper disable once CheckNamespace
namespace DotGod.Node.Path.From;

public sealed class String : Envelope<NodePath>
{
	public String(System.String path) : this
	(
		new Value<System.String>(path)
	)
	{
	}
	
	public String(Any<System.String> path) : base
	(
		new Actual<NodePath>(
			() => new NodePath(path.Value))
	)
	{
	}
}