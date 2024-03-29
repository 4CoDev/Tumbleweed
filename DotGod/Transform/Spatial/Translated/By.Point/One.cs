using Godot;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace DotGod.Transform.Spatial.Translated.By.Point;

public sealed class One : Tumbleweed.Property.Output.Envelope<Transform3D>
{
	public One
	(Tumbleweed.Property.Output.Any<Transform3D> transform, Any<Any> translation
	) : base
	(
		new Vector.One(
			transform,
			new Mathematics.Vector.Spatial.Godot.From.Tumbleweed.One(translation))
	)
	{
	}
}