using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.FromEnumerable;

namespace DotGod.Spatial.Transform;

public sealed class ProductOfTransforms : ScalarEnvelope<Transform3D>
{
	public ProductOfTransforms
	(
		params Transform3D[] transforms
	) : this
	(
		new EnumerableWithElements<Transform3D>(transforms)
	)
	{
	}
	
	public ProductOfTransforms
	(
		IEnumerable<Transform3D> transforms
	) : base
	(
		new AggregatedByExpression<Transform3D>(
			transforms,
			Expression)
	)
	{
	}
	
	private static Transform3D Expression
	(
		Transform3D parent,
		Transform3D child
	) =>
	(
		parent * child
	);
}