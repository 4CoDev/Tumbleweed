using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical._Mesh._ArrayMesh.OfGodot;

public sealed class MeshWithSurfaceTool : IScalar<Godot.ArrayMesh>
{
	public MeshWithSurfaceTool
	(
		SurfaceTool tool,
		IScalar<Godot.ArrayMesh> mesh
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
		Godot.ArrayMesh mesh
	) : this
	(
		tool,
		new ScalarValue<Godot.ArrayMesh>(mesh)
	)
	{
	}
	
	public MeshWithSurfaceTool
	(
		IScalar<SurfaceTool> tool,
		IScalar<Godot.ArrayMesh> mesh
	)
	{
		this.tool = tool;
		this.mesh = mesh;
	}

	public Godot.ArrayMesh Value => tool.Value.Commit(mesh.Value);

	private readonly IScalar<SurfaceTool> tool;
	
	private readonly IScalar<Godot.ArrayMesh> mesh;
}