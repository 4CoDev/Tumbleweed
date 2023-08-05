using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using DotGod.Vector.Planar.From.Point;
using DotGod.Vector.Spatial.From.Point;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using One = DotGod.Vector.Spatial.From.Point.One;

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
			result.SetNormal(new One(vertex.Normal).Value);
			result.SetColor(vertex.Color.Value);
			result.SetUV(new Vector.Planar.From.Point.One(vertex.UV).Value);
			result.AddVertex(new One(vertex.Translation).Value);
			return result;
		}
	}

	private readonly Any<SurfaceTool> tool;
	
	private readonly IVertex vertex;
}