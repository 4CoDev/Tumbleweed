using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Surfaces.SurfaceTools.OfGodot;

public sealed class ToolFromSurface : IScalar<SurfaceTool>
{
	public ToolFromSurface
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface
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

	private readonly IScalar<ArrayMesh> mesh;
	
	private readonly IScalar<Int32> surface;
}