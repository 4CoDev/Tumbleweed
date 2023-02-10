using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.ArrayMeshes;

public sealed class ArrayMeshWithSurfaceTool : IScalar<ArrayMesh>
{
	public ArrayMeshWithSurfaceTool
	(
		IScalar<SurfaceTool> tool,
		IScalar<ArrayMesh> mesh
	)
	{
		this.tool = tool;
		this.mesh = mesh;
	}
	
	public ArrayMesh Value()
	{
		return tool.Value().Commit(mesh.Value());
	}
	
	private readonly IScalar<SurfaceTool> tool;
	
	private readonly IScalar<ArrayMesh> mesh;
}