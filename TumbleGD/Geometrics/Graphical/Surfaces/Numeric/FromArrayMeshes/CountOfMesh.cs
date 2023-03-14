using Godot;
using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Numerics.Integers.Natural.FromSystem;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Surfaces.Numeric.
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