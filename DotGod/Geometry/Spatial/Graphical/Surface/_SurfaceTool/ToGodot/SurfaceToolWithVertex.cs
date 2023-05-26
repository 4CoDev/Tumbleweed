using DotGod.Geometry.Spatial.Graphical.Vertex;
using DotGod.Vector.Planar;
using DotGod.Vector.Spatial.Godot;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Surface._SurfaceTool.
	ToGodot;

public sealed class SurfaceToolWithVertex : IScalar<SurfaceTool>
{
	public SurfaceToolWithVertex(IScalar<SurfaceTool> tool, IVertex vertex)
	{
		this.tool = tool;
		this.vertex = vertex;
	}

	public SurfaceTool Value
	{
		get
		{
			SurfaceTool result = tool.Value;
			result.SetNormal(new Vector3FromPoint(vertex.Normal).Value);
			result.SetColor(vertex.Color.Value);
			result.SetUV(new Vector2FromPlanar(vertex.UV).Value);
			result.AddVertex(new Vector3FromPoint(vertex.Translation).Value);
			return result;
		}
	}

	private readonly IScalar<SurfaceTool> tool;
	
	private readonly IVertex vertex;
}