using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Transform.Spatial;

public sealed class ProductOfTwoTransforms : Envelope<Transform3D>
{
	public ProductOfTwoTransforms
	(
		Transform3D parent,
		Transform3D child
	) : this
	(
		new Value<Transform3D>(parent),
		new Value<Transform3D>(child)
	)
	{
	}
	
	public ProductOfTwoTransforms
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