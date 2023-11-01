using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.From.Enumerable;
using Tumbleweed.Property.Output.Nested;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.With.SurfaceTool.Appended;

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