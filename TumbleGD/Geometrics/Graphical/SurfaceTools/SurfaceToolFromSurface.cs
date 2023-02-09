using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.SurfaceTools;

public sealed class SurfaceToolFromSurface : IScalar<SurfaceTool>
{
	public SurfaceToolFromSurface
	(
		IScalar<ArrayMesh> mesh,
		IScalar<int> surface
	)
	{
		this.mesh = mesh;
		this.surface = surface;
	}
	
	public SurfaceTool Value()
	{
		SurfaceTool surfaceTool = new SurfaceTool();
		surfaceTool.CreateFrom(mesh.Value(), surface.Value());
		return surfaceTool;
	}
	
	private readonly IScalar<ArrayMesh> mesh;
	
	private readonly IScalar<int> surface;
}