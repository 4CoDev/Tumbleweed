using DotGod.Point.Spatial.From.Vector;
using DotGod.Transform.Spatial.Origin.Vector;
using DotGod.Transform.Spatial.Translated.By.Point;
using Godot;
using Tumbleweed.Number.Real;

namespace DotGod.Point.Spatial.Transformed;

public sealed class One : Tumbleweed.Point.Spatial.Envelope<Any>
{
	public One
	(Tumbleweed.Point.Spatial.Any<Any> point, Tumbleweed.Scalar.Immutable.Any<Transform3D> transform
	) : base
	(
		new From.Vector.One(
			new Transform.Spatial.Origin.Vector.One(
				new Transform.Spatial.Translated.By.Point.One(transform, point)))
	)
	{
	}
}