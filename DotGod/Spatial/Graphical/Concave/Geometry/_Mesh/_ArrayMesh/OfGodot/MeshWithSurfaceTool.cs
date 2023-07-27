using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.OfGodot;

public sealed class MeshWithSurfaceTool : Any<Godot.ArrayMesh>
{
	public MeshWithSurfaceTool
	(
		SurfaceTool tool,
		Any<Godot.ArrayMesh> mesh
	) : this
	(
		new Tumbleweed.Scalar.Of.Value<SurfaceTool>(tool),
		mesh
	)
	{
	}
	
	public MeshWithSurfaceTool
	(
		Any<SurfaceTool> tool,
		Godot.ArrayMesh mesh
	) : this
	(
		tool,
		new Tumbleweed.Scalar.Of.Value<Godot.ArrayMesh>(mesh)
	)
	{
	}
	
	public MeshWithSurfaceTool
	(
		Any<SurfaceTool> tool,
		Any<Godot.ArrayMesh> mesh
	)
	{
		this.tool = tool;
		this.mesh = mesh;
	}

	public Godot.ArrayMesh Value => tool.Value.Commit(mesh.Value);

	private readonly Any<SurfaceTool> tool;
	
	private readonly Any<Godot.ArrayMesh> mesh;
}