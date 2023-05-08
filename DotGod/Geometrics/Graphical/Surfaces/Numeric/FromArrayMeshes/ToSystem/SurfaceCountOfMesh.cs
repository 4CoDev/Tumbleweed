using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Surfaces.Numeric.FromArrayMeshes.
	ToSystem;

public sealed class SurfaceCountOfMesh : ScalarEnvelope<Int32>
{
	public SurfaceCountOfMesh(IScalar<ArrayMesh> mesh) : base
	(
		new ResultOfFunction<Int32>(
			() => mesh.Value.GetSurfaceCount())
	)
	{
	}
}