using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.OfGodot;

public sealed class MeshWithSurfaceTool : Any<Godot.ArrayMesh>
{
	public MeshWithSurfaceTool
	(
		SurfaceTool tool,
		Any<Godot.ArrayMesh> mesh
	) : this
	(
		new Value<SurfaceTool>(tool),
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
		new Value<Godot.ArrayMesh>(mesh)
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