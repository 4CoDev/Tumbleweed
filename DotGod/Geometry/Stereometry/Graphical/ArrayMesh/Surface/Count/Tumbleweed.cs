using Tumbleweed.Mathematics.Number.Natural.From.System;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Stereometry.Graphical.ArrayMesh.Surface.Count;

public sealed class Tumbleweed : global::Tumbleweed.Mathematics.Number.Natural.Envelope
{
	public Tumbleweed(Any<Godot.ArrayMesh> mesh) : base
	(
		new One(
			new System(mesh))
	)
	{
	}
}