using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.Node3D.Member.Transform;

public sealed class One : Envelope<Transform3D>
{
	public One(Godot.Node3D node) : this
	(
		new Value<Godot.Node3D>(node)
	)
	{
	}
	
	public One(Any<Godot.Node3D> node) : base
	(
		new Actual<Transform3D>(
			() => node.Value.Transform)
	)
	{
	}
}