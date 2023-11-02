using Godot;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;
using Tumbleweed.Property.Output.With.Value;

namespace DotGod.Transform.Spatial.Product;

public sealed class Two : Envelope<Transform3D>
{
	public Two
	(
		Transform3D parent,
		Transform3D child
	) : this
	(
		new One<Transform3D>(parent),
		new One<Transform3D>(child)
	)
	{
	}
	
	public Two
	(
		Any<Transform3D> parent,
		Any<Transform3D> child
	) : base
	(
		new Actual<Transform3D>(
			() => parent.Value * child.Value)
	)
	{
	}
}