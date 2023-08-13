using DotGod.Point.Spatial.From.Vector;
using Godot;
using Tumbleweed.Number.Real;

namespace DotGod.Transform.Spatial.Origin.Point;

public sealed class One : Tumbleweed.Point.Spatial.Envelope<Any>
{
	public One(Tumbleweed.Scalar.Immutable.Any<Transform3D> transform) : base
	(
		new DotGod.Point.Spatial.From.Vector.One(
			new Vector.One(transform))
	)
	{
	}
}