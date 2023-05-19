using DotGod.Geometry.Spatial.Graphical.Vertices;
using DotGod.Vectors.Planar;
using DotGod.Vectors.Spatial.Godot;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Surfaces.SurfaceTools.
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