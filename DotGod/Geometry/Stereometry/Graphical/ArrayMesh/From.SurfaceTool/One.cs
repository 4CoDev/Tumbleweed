using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Enumerable = DotGod.Geometry.Stereometry.Graphical.ArrayMesh.With.SurfaceTool.Appended.Enumerable;

namespace DotGod.Geometry.Stereometry.Graphical.ArrayMesh.From.SurfaceTool;

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