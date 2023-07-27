using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Function;

namespace DotGod.Spatial.Transform;

public sealed class ProductOfTwoTransforms : Envelope<Transform3D>
{
	public ProductOfTwoTransforms
	(
		Transform3D parent,
		Transform3D child
	) : this
	(
		new Tumbleweed.Scalar.Of.Value<Transform3D>(parent),
		new Tumbleweed.Scalar.Of.Value<Transform3D>(child)
	)
	{
	}
	
	public ProductOfTwoTransforms
	(
		Any<Transform3D> parent,
		Any<Transform3D> child
	) : base
	(
		new Tumbleweed.Scalar.Function.Result<Transform3D>(
			() => parent.Value * child.Value)
	)
	{
	}
}