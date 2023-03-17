using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Surfaces.Numeric.FromArrayMeshes.
	ToSystem;

public sealed class SurfaceCountOfMesh : ScalarEnvelope<Int32>
{
	public SurfaceCountOfMesh(IScalar<ArrayMesh> mesh) : base
	(
		new ValueOfFunction<Int32>(
			() => mesh.Value.GetSurfaceCount())
	)
	{
	}
}