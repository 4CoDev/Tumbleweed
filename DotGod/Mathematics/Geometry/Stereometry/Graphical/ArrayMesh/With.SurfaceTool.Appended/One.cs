using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.With.SurfaceTool.Appended;

public sealed class One : Any<Godot.ArrayMesh>
{
	public One
	(
		Godot.SurfaceTool tool,
		Any<Godot.ArrayMesh> mesh
	) : this
	(
		new Value<Godot.SurfaceTool>(tool),
		mesh
	)
	{
	}
	
	public One
	(
		Any<Godot.SurfaceTool> tool,
		Godot.ArrayMesh mesh
	) : this
	(
		tool,
		new Value<Godot.ArrayMesh>(mesh)
	)
	{
	}
	
	public One
	(
		Any<Godot.SurfaceTool> tool,
		Any<Godot.ArrayMesh> mesh
	)
	{
		this.tool = tool;
		this.mesh = mesh;
	}

	public Godot.ArrayMesh Value => tool.Value.Commit(mesh.Value);

	private readonly Any<Godot.SurfaceTool> tool;
	
	private readonly Any<Godot.ArrayMesh> mesh;
}