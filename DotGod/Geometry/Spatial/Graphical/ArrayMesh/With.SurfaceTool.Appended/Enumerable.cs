using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.From.Enumerable;
using Tumbleweed.Scalar.Immutable.Nested;

namespace DotGod.Geometry.Spatial.Graphical.ArrayMesh.With.SurfaceTool.Appended;

public sealed class Enumerable : Envelope<Godot.ArrayMesh>
{
	public Enumerable
	(
		IEnumerable<Godot.SurfaceTool> tools,
		Any<Godot.ArrayMesh> mesh
	) : base
	(
		new Value<Godot.ArrayMesh>(
			new Aggregated
			<
				Godot.SurfaceTool,
				Any<Godot.ArrayMesh>
			>
			(
				tools,
				mesh,
				Expression
			))
	)
	{
	}

	private static Any<Godot.ArrayMesh> Expression
	(
		Any<Godot.ArrayMesh> mesh,
		Godot.SurfaceTool tool
	) =>
	(
		new One(tool, mesh)
	);
}