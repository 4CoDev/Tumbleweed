using DotGod.Geometry.Spatial.Graphical.Vertex;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Graphical.SurfaceTool.With.Vertex.
	Appended;

public sealed class One : Any<Godot.SurfaceTool>
{
	public One(Any<Godot.SurfaceTool> tool, Any vertex)
	{
		this.tool = tool;
		this.vertex = vertex;
	}

	public Godot.SurfaceTool Value
	{
		get
		{
			Godot.SurfaceTool result = tool.Value;
			result.SetNormal(new Vector.Spatial.From.Point.One(vertex.Normal).Value);
			result.SetColor(vertex.Color.Value);
			result.SetUV(new Vector.Planar.From.Point.One(vertex.UV).Value);
			result.AddVertex(new Vector.Spatial.From.Point.One(vertex.Translation).Value);
			return result;
		}
	}

	private readonly Any<Godot.SurfaceTool> tool;
	
	private readonly Any vertex;
}