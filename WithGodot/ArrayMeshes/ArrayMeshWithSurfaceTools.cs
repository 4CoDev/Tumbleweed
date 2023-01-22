using Godot;
using Tumbleweed.Scalars;

namespace Tumbleweed.WithGodot.ArrayMeshes;

public sealed class ArrayMeshWithSurfaceTools : IScalar<ArrayMesh>
{
	public ArrayMeshWithSurfaceTools
	(
		IEnumerable<IScalar<SurfaceTool>> tools,
		IScalar<ArrayMesh> mesh
	)
	{
		this.tools = tools;
		this.mesh = mesh;
	}
	
	public ArrayMesh Value()
	{
		IScalar<ArrayMesh> result = mesh;
		foreach (IScalar<SurfaceTool> tool in tools)
		{
			result = new ArrayMeshWithSurfaceTool(tool, result);
		}
		return result.Value();
	}
	
	private readonly IEnumerable<IScalar<SurfaceTool>> tools;
	
	private readonly IScalar<ArrayMesh> mesh;
}