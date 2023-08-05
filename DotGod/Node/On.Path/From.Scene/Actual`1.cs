using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.With;
using String = DotGod.Node.Path.From.String;

namespace DotGod.Node.On.Path.From.Scene;

public sealed class Actual<T> : Envelope<T> where T : Godot.Node
{
	public Actual(Godot.Node relation, System.String path) : this
	(
		new Value<Godot.Node>(relation),
		path
	)
	{
	}
	
	public Actual(Any<Godot.Node> relation, System.String path) : this
	(
		relation, new Value<System.String>(path)
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
		relation, new Value<NodePath>(path)
	)
	{
	}
	
	public Actual
	(
		Any<Godot.Node> relation,
		Any<NodePath> path
	) : base
	(
		new Tumbleweed.Scalar.Immutable.Function.Result.Actual<T>(
			() => relation.Value.GetNode<T>(path.Value))
	)
	{
	}
}