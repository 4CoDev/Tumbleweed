using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;
using String = DotGod.Node.Path.From.String;

namespace DotGod.Node.From.Scene.On.Path;

public sealed class Lazy : Envelope<Godot.Node>
{
	public Lazy(Godot.Node relation, System.String path) : this
	(
		new Value<Godot.Node>(relation),
		path
	)
	{
	}
	
	public Lazy(Any<Godot.Node> relation, System.String path) : this
	(
		relation, new Value<System.String>(path)
	)
	{
	}
	
	public Lazy(Any<Godot.Node> relation, Any<System.String> path) : this
	(
		relation, new String(path)
	)
	{
	}
	
	public Lazy(Any<Godot.Node> relation, NodePath path) : this
	(
		relation, new Value<NodePath>(path)
	)
	{
	}
	
	public Lazy
	(
		Any<Godot.Node> relation,
		Any<NodePath> path
	) : base
	(
		new Lazy<Godot.Node>(relation, path)
	)
	{
	}
}