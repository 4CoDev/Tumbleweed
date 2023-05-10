using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Meshes.MeshDataTools.FromArrayMesh;

public sealed class MeshDataToolFromSurface : IScalar<MeshDataTool>
{
	public MeshDataToolFromSurface
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface
	)
	{
		this.mesh = mesh;
		this.surface = surface;
	}

	public MeshDataTool Value
	{
		get
		{
			MeshDataTool meshDataTool = new MeshDataTool();
			meshDataTool.CreateFromSurface(mesh.Value, surface.Value);
			return meshDataTool;
		}
	}

	private readonly IScalar<ArrayMesh> mesh;
	
	private readonly IScalar<Int32> surface;
}