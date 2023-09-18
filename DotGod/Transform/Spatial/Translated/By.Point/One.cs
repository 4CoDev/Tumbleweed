using DotGod.Vector.Spatial.From.Point;
using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial.Generic;

namespace DotGod.Transform.Spatial.Translated.By.Point;

public sealed class One : Tumbleweed.Scalar.Immutable.Envelope<Transform3D>
{
	public One
	(Tumbleweed.Scalar.Immutable.Any<Transform3D> transform, Any<Any> translation
	) : base
	(
		new Vector.One(
			transform,
			new DotGod.Vector.Spatial.From.Point.One(translation))
	)
	{
	}
}