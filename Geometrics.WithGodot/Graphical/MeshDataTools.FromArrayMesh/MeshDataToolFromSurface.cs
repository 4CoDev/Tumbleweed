using Godot;
using Tumbleweed.Scalars;

namespace Tumbleweed.Geometrics.WithGodot.Graphical.MeshDataTools.FromArrayMesh;

public sealed class MeshDataToolFromSurface : IScalar<MeshDataTool>
{
	public MeshDataToolFromSurface
	(
		IScalar<ArrayMesh> mesh,
		IScalar<int> surface
	)
	{
		this.mesh = mesh;
		this.surface = surface;
	}
	
	public MeshDataTool Value()
	{
		MeshDataTool meshDataTool = new MeshDataTool();
		meshDataTool.CreateFromSurface(mesh.Value(), surface.Value());
		return meshDataTool;
	}

	private readonly IScalar<ArrayMesh> mesh;
	
	private readonly IScalar<int> surface;
}