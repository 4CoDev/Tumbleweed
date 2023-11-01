using Godot;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;
using Tumbleweed.Property.Output.With;

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