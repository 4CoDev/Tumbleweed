using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.FromEnumerable;

namespace DotGod.Geometry.Spatial.Graphical._Mesh._ArrayMesh.OfGodot;

public sealed class MeshWithSurfaceTools : ScalarEnvelope<Godot.ArrayMesh>
{
	public MeshWithSurfaceTools
	(
		IEnumerable<SurfaceTool> tools,
		IScalar<Godot.ArrayMesh> mesh
	) : base
	(
		new ScalarOfNested<Godot.ArrayMesh>(
			new AggregatedByExpression<SurfaceTool, IScalar<Godot.ArrayMesh>>(
				tools,
				mesh,
				Expression))
	)
	{
	}

	private static IScalar<Godot.ArrayMesh> Expression
	(
		IScalar<Godot.ArrayMesh> mesh,
		SurfaceTool tool
	) =>
	(
		new MeshWithSurfaceTool(tool, mesh)
	);
}