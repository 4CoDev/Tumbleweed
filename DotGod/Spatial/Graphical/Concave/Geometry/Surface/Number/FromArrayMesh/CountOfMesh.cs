using Godot;
using Tumbleweed.Number.Natural;
using Tumbleweed.Number.Natural.From.System;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface.Number.FromArrayMesh;

public sealed class CountOfMesh : Envelope
{
	public CountOfMesh(Any<ArrayMesh> mesh) : base
	(
		new One(
			new ToSystem.SurfaceCountOfMesh(mesh))
	)
	{
	}
}