using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Meshes.ArrayMeshes.FromGodot;

public sealed class MeshWithSurfaceTools : IScalar<ArrayMesh>
{
	public MeshWithSurfaceTools
	(
		IEnumerable<IScalar<SurfaceTool>> tools,
		IScalar<ArrayMesh> mesh
	)
	{
		this.tools = tools;
		this.mesh = mesh;
	}

	public ArrayMesh Value
	{
		get
		{
			IScalar<ArrayMesh> result = mesh;
			foreach (IScalar<SurfaceTool> tool in tools)
			{
				result = new MeshWithSurfaceTool(tool, result);
			}
			return result.Value;
		}
	}

	private readonly IEnumerable<IScalar<SurfaceTool>> tools;
	
	private readonly IScalar<ArrayMesh> mesh;
}