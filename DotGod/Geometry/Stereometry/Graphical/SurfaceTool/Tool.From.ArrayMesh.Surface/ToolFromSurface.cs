using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Stereometry.Graphical.SurfaceTool.Tool.From.ArrayMesh.Surface;

public sealed class ToolFromSurface : Any<Godot.SurfaceTool>
{
	public ToolFromSurface
	(
		Any<Godot.ArrayMesh> mesh,
		Any<Int32> surface
	)
	{
		this.mesh = mesh;
		this.surface = surface;
	}

	public Godot.SurfaceTool Value
	{
		get
		{
			Godot.SurfaceTool surfaceTool = new Godot.SurfaceTool();
			surfaceTool.CreateFrom(mesh.Value, surface.Value);
			return surfaceTool;
		}
	}

	private readonly Any<Godot.ArrayMesh> mesh;
	
	private readonly Any<Int32> surface;
}