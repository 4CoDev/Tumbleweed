using DotGod.Planar.Vector;
using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using DotGod.Spatial.Vector.Godot;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.
	ToGodot;

public sealed class SurfaceToolWithVertex : Any<SurfaceTool>
{
	public SurfaceToolWithVertex(Any<SurfaceTool> tool, IVertex vertex)
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

	private readonly Any<SurfaceTool> tool;
	
	private readonly IVertex vertex;
}