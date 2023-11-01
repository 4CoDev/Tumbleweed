using Godot;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace DotGod.Transform.Spatial.Origin.Point;

public sealed class One : Envelope<Any>
{
	public One(Tumbleweed.Property.Output.Any<Transform3D> transform) : base
	(
		new Mathematics.Vector.Spatial.Tumbleweed.From.Godot.One(
			new Vector.One(transform))
	)
	{
	}
}