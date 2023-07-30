using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.From.Enumerable;
using Tumbleweed.Scalar.Immutable.Nested;
using Tumbleweed.Scalar.Immutable.Of;
using Scalar = Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.OfGodot;

public sealed class MeshWithSurfaceTools : Envelope<Godot.ArrayMesh>
{
	public MeshWithSurfaceTools
	(
		IEnumerable<SurfaceTool> tools,
		Any<Godot.ArrayMesh> mesh
	) : base
	(
		new Value<Godot.ArrayMesh>(
			new Aggregated
			<
				SurfaceTool,
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
		SurfaceTool tool
	) =>
	(
		new MeshWithSurfaceTool(tool, mesh)
	);
}