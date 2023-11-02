using Godot;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;
using String = DotGod.Node.Path.From.String;

namespace DotGod.Node.Generic.From.Scene.On.Path;

public sealed class Actual<T> : Envelope<T> where T : Godot.Node
{
	public Actual(Godot.Node relation, System.String path) : this
	(
		new One<Godot.Node>(relation),
		path
	)
	{
	}
	
	public Actual(Any<Godot.Node> relation, System.String path) : this
	(
		relation, new One<System.String>(path)
	)
	{
	}
	
	public Actual(Any<Godot.Node> relation, Any<System.String> path) : this
	(
		relation, new String(path)
	)
	{
	}
	
	public Actual(Any<Godot.Node> relation, NodePath path) : this
	(
		relation, new One<NodePath>(path)
	)
	{
	}
	
	public Actual
	(
		Any<Godot.Node> relation,
		Any<NodePath> path
	) : base
	(
		new Tumbleweed.Property.Output.Function.Result.Actual<T>(
			() => relation.Value.GetNode<T>(path.Value))
	)
	{
	}
}