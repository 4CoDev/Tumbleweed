using Godot;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace DotGod.Mathematics.Vector.Spatial.Tumbleweed.Transformed;

public sealed class One : Envelope<Any>
{
	public One
	(Any<Any> point, global::Tumbleweed.Property.Output.Any<Transform3D> transform
	) : base
	(
		new From.Godot.One(
			new Transform.Spatial.Origin.Vector.One(
				new Transform.Spatial.Translated.By.Point.One(transform, point)))
	)
	{
	}
}