using Godot;
using Tumbleweed.Enumerable;
using Scalar = Tumbleweed.Scalar;

namespace DotGod.Spatial.Transform;

public sealed class ProductOfTransforms : Scalar.Envelope<Transform3D>
{
	public ProductOfTransforms
	(
		params Transform3D[] transforms
	) : this
	(
		new Concatenated<Transform3D>(transforms)
	)
	{
	}
	
	public ProductOfTransforms
	(
		IEnumerable<Transform3D> transforms
	) : base
	(
		new Scalar.From.Enumerable.Aggregated<Transform3D>(
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