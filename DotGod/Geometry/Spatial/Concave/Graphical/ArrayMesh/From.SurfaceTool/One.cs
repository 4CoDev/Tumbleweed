using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Enumerable = DotGod.Geometry.Spatial.Concave.Graphical.ArrayMesh.With.SurfaceTool.Appended.Enumerable;

namespace DotGod.Geometry.Spatial.Concave.Graphical.ArrayMesh.From.SurfaceTool;

public sealed class One : Envelope<Godot.ArrayMesh>
{
	public One
	(
		IEnumerable<Godot.SurfaceTool> tools
	) : base
	(
		new Enumerable(
			tools,
			new New<Godot.ArrayMesh>())
	)
	{
	}
}