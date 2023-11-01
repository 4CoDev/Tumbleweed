using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Property.Output.From.Enumerable;
using Property = Tumbleweed.Property;

namespace DotGod.Transform.Spatial.Product;

public sealed class Multiple : Property::Output.Envelope<Transform3D>
{
	public Multiple
	(
		params Transform3D[] transforms
	) : this
	(
		new Concatenated<Transform3D>(transforms)
	)
	{
	}
	
	public Multiple
	(
		IEnumerable<Transform3D> transforms
	) : base
	(
		new Aggregated<Transform3D>(
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