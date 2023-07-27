using Godot;
using Scalar = Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.OfGodot;

public sealed class MeshWithSurfaceTools : Scalar.Envelope<Godot.ArrayMesh>
{
	public MeshWithSurfaceTools
	(
		IEnumerable<SurfaceTool> tools,
		Tumbleweed.Scalar.Any<Godot.ArrayMesh> mesh
	) : base
	(
		new Scalar.Of.Nested<Godot.ArrayMesh>(
			new Scalar.From.Enumerable.Aggregated
			<
				SurfaceTool,
				Scalar.Any<Godot.ArrayMesh>
			>
			(
				tools,
				mesh,
				Expression
			))
	)
	{
	}

	private static Scalar.Any<Godot.ArrayMesh> Expression
	(
		Scalar.Any<Godot.ArrayMesh> mesh,
		SurfaceTool tool
	) =>
	(
		new MeshWithSurfaceTool(tool, mesh)
	);
}