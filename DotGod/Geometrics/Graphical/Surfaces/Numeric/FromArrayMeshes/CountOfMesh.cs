using Godot;
using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Integers.Natural.FromSystem;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Surfaces.Numeric.
	FromArrayMeshes;

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