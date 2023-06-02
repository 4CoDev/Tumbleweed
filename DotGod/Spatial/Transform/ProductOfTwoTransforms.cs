using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Transform;

public sealed class ProductOfTwoTransforms : ScalarEnvelope<Transform3D>
{
	public ProductOfTwoTransforms
	(
		Transform3D parent,
		Transform3D child
	) : this
	(
		new ScalarValue<Transform3D>(parent),
		new ScalarValue<Transform3D>(child)
	)
	{
	}
	
	public ProductOfTwoTransforms
	(
		IScalar<Transform3D> parent,
		IScalar<Transform3D> child
	) : base
	(
		new ResultOfFunction<Transform3D>(
			() => parent.Value * child.Value)
	)
	{
	}
}