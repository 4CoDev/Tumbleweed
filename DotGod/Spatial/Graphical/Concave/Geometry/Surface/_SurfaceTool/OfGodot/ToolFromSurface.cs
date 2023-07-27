using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.OfGodot;

public sealed class ToolFromSurface : Any<SurfaceTool>
{
	public ToolFromSurface
	(
		Any<ArrayMesh> mesh,
		Any<Int32> surface
	)
	{
		this.mesh = mesh;
		this.surface = surface;
	}

	public SurfaceTool Value
	{
		get
		{
			SurfaceTool surfaceTool = new SurfaceTool();
			surfaceTool.CreateFrom(mesh.Value, surface.Value);
			return surfaceTool;
		}
	}

	private readonly Any<ArrayMesh> mesh;
	
	private readonly Any<Int32> surface;
}