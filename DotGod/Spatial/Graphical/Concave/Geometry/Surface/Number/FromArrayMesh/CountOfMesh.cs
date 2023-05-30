using Godot;
using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Number.Integer.Natural.FromSystem;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface.Number.FromArrayMesh;

public sealed class CountOfMesh : NaturalEnvelope
{
	public CountOfMesh(IScalar<ArrayMesh> mesh) : base
	(
		new NaturalFromInt32(
			new ToSystem.SurfaceCountOfMesh(mesh))
	)
	{
	}
}