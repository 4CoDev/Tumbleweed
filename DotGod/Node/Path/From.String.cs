using Godot;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;
using Tumbleweed.Property.Output.With;

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