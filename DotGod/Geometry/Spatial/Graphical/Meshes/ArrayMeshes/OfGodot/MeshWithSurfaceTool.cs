using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Meshes.ArrayMeshes.OfGodot;

public sealed class MeshWithSurfaceTool : IScalar<ArrayMesh>
{
	public MeshWithSurfaceTool
	(
		SurfaceTool tool,
		IScalar<ArrayMesh> mesh
	) : this
	(
		new ScalarValue<SurfaceTool>(tool),
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
		new ScalarValue<ArrayMesh>(mesh)
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