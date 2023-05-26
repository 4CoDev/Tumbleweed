using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Surface.Number.FromArrayMesh.
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