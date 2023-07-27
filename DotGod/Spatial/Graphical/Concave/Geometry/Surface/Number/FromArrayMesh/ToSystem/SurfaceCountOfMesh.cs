using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Function;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface.Number.FromArrayMesh.
	ToSystem;

public sealed class SurfaceCountOfMesh : Envelope<Int32>
{
	public SurfaceCountOfMesh(Any<ArrayMesh> mesh) : base
	(
		new Tumbleweed.Scalar.Function.Result<Int32>(
			() => mesh.Value.GetSurfaceCount())
	)
	{
	}
}