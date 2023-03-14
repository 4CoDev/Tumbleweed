using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Meshes.ArrayMeshes.FromGodot;

public sealed class MeshWithSurfaceTool : IScalar<ArrayMesh>
{
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