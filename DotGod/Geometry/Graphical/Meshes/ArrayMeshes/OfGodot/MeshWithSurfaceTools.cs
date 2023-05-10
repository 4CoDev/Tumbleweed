using Godot;
using Tumbleweed.Scalars;
using Tumbleweed.Scalars.FromEnumerable;

namespace DotGod.Geometry.Graphical.Meshes.ArrayMeshes.OfGodot;

public sealed class MeshWithSurfaceTools : ScalarEnvelope<ArrayMesh>
{
	public MeshWithSurfaceTools
	(
		IEnumerable<SurfaceTool> tools,
		IScalar<ArrayMesh> mesh
	) : base
	(
		new ScalarOfNested<ArrayMesh>(
			new AggregatedByExpression<SurfaceTool, IScalar<ArrayMesh>>(
				tools,
				mesh,
				Expression))
	)
	{
	}

	private static IScalar<ArrayMesh> Expression
	(
		IScalar<ArrayMesh> mesh,
		SurfaceTool tool
	) =>
	(
		new MeshWithSurfaceTool(tool, mesh)
	);
}