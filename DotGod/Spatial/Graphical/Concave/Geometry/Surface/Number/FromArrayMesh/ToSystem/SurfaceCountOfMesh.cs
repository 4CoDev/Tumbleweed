using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface.Number.FromArrayMesh.
	ToSystem;

public sealed class SurfaceCountOfMesh : Envelope<Int32>
{
	public SurfaceCountOfMesh(Any<ArrayMesh> mesh) : base
	(
		new Actual<Int32>(
			() => mesh.Value.GetSurfaceCount())
	)
	{
	}
}