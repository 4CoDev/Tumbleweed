using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Meshes.ArrayMeshes.OfGodot;

public sealed class MeshWithSurfaceTool : IScalar<ArrayMesh>
{
	public MeshWithSurfaceTool
	(
		SurfaceTool tool,
		IScalar<ArrayMesh> mesh
	) : this
	(
		new ScalarOfValue<SurfaceTool>(tool),
		mesh
	)
	{
	}
	
	public MeshWithSurfaceTool
	(
		IScalar<SurfaceTool> tool,
		ArrayMesh mesh
	) : this
	(
		tool,
		new ScalarOfValue<ArrayMesh>(mesh)
	)
	{
	}
	
	public MeshWithSurfaceTool
	(
		IScalar<SurfaceTool> tool,
		IScalar<ArrayMesh> mesh
	)
	{
		this.tool = tool;
		this.mesh = mesh;
	}

	public ArrayMesh Value => tool.Value.Commit(mesh.Value);

	private readonly IScalar<SurfaceTool> tool;
	
	private readonly IScalar<ArrayMesh> mesh;
}