using DotGod.Point.Spatial.From.Vector;
using Godot;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real;

namespace DotGod.Transform.Spatial.Origin.Point;

public sealed class One : Envelope<Any>
{
	public One(Tumbleweed.Scalar.Immutable.Any<Transform3D> transform) : base
	(
		new DotGod.Point.Spatial.From.Vector.One(
			new Vector.One(transform))
	)
	{
	}
}